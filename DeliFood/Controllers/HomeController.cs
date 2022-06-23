using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DeliFood.Models;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;

using DeliFood.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace DeliFood.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _proRepo;
        public HomeController(IProductRepository proRepo)
        {
            _proRepo = proRepo;
        }
     
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewProduct(int cat = 0)
        {
            var lsProduct = _proRepo.GetAll();
            if(cat != 0)
            {
                if (cat == 1)
                {
                    lsProduct = lsProduct.Where(x => x.Category.CatName == "Vegetable").Take(6).ToList();
                    goto n;
                }
                    
                if(cat == 2)
                {
                    lsProduct = lsProduct.Where(x => x.Category.CatName == "Meat").Take(6).ToList();
                    goto n;
                }
                else
                {
                    lsProduct = lsProduct.Where(x => x.Category.CatName == "Combo").Take(6).ToList();
                }

            }
            else
            {
                lsProduct = lsProduct.Take(8).ToList();
            }
            n:
            return PartialView("_ProductPartialView", lsProduct);
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
