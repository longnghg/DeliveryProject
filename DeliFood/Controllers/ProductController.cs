using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeliFood.Interfaces;
using DeliFood.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DeliFood.Controllers
{
    public class ProductController : Controller
    {
        IProductRepository _productRepo;
        ICategoryRepository _catRepo;
        public ProductController(IProductRepository productRepo, ICategoryRepository catRepo)
        {
            _productRepo = productRepo;
            _catRepo = catRepo;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var lsCat = _catRepo.GetAll();
            ViewBag.lsCat = new SelectList(_catRepo.GetAll(), "CatId", "CatName");
            return View();
        }
        
        public IActionResult ViewProduct(int cat = 0, int price = 0, string name = null,string orderby = "0")
        {
            var lsProduct = _productRepo.GetAll();
            if(cat != 0)
            {
                lsProduct = lsProduct.Where(x => x.CatId == cat).ToList();
            }
            if(price != 0)
            {
                lsProduct = lsProduct.Where(x => x.Price <= price).ToList();
            }
            if (!String.IsNullOrEmpty(name))
            {
                lsProduct = lsProduct.Where(x => Helpers.Convert.LocDau(x.ProductName).ToUpper().Contains(name)).ToList();
            }
            // ordering
            if(orderby != "0" )
            {
                if (orderby == "name")
                    lsProduct = lsProduct.OrderBy(x => x.ProductName).ToList();
                else if (orderby == "pricelow")
                    lsProduct = lsProduct.OrderByDescending(x => x.Price).ToList();
                else
                    lsProduct = lsProduct.OrderBy(x => x.Price).ToList();
            }
            return PartialView("_ShowPartialView", lsProduct);
        }
        public IActionResult Details(int id)
        {
            Product p = _productRepo.Get(id);
            var catID = p.CatId;
            List<Product> lsProductsSameCat = _catRepo.Get(catID).Products.ToList();
            ViewBag.lsProductsSameCat = lsProductsSameCat.Where(x=> x.ProductId != p.ProductId).ToList().Take(4);
            return View(p);
        }
    }
}
