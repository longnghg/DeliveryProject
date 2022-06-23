using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DeliFood.Models;
using DeliFood.Interfaces;
using PagedList.Core;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

namespace DeliFood.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]

    public class ProductController : Controller
    {
        private IProductRepository _prodRepo;
        private ICategoryRepository _catRepo;
        private INotyfService _notyf { get; }

        public ProductController( IProductRepository prodRepo, ICategoryRepository catRepo, INotyfService notyf)
        {
            _prodRepo = prodRepo;
            _catRepo = catRepo;
            _notyf = notyf;
        }

        // GET: Admin/Product
        public IActionResult Index(int? page = null, string name = null, int? cat = null, int? status = null)

        {
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var lsProduct = _prodRepo.GetAll();
            if(name != null)
            {
                lsProduct = lsProduct.Where(x => Helpers.Convert.LocDau(x.ProductName).ToUpper().Contains(name)).ToList();
                ViewBag.NameFilter = name;
            }
            if(cat != null)
            {
                lsProduct = lsProduct.Where(x => x.CatId == cat).ToList();
                ViewBag.CatFilter = cat;

            }
            if (status != null)
            {
                if (status == 1)
                    lsProduct = lsProduct.Where(x => x.UnitInStock > 0).ToList();
                else
                    lsProduct = lsProduct.Where(x => x.UnitInStock  == 0).ToList();

                ViewBag.StatusFilter = status;
            }
            ViewBag.lsCat = new SelectList(_catRepo.GetAll(), "CatId", "CatName");
            List<SelectListItem> lsStatus = new List<SelectListItem>();
            lsStatus.Add(new SelectListItem() { Text = "In stock", Value = "1" });
            lsStatus.Add(new SelectListItem() { Text = "Out of stock", Value = "-1" });

            ViewBag.lsStatus = lsStatus;
            var pageSize = 10;
            PagedList<Product> models = new PagedList<Product>(lsProduct.AsQueryable(), pageNumber, pageSize);
            return View(models);
        }
        [HttpPost]
        public IActionResult Filter(FilterProduct filterObj)
        {
            try
            {
                // cú pháp ?dept=...&create=...
                string Url = $"/Admin/Product?page=1";

                if (!string.IsNullOrEmpty(filterObj.Name))
                {
                    Url += $"&name={filterObj.Name}";
                }

                if (filterObj.IdCat != 0)
                {
                    Url += $"&cat={filterObj.IdCat}";
                }
                if (filterObj.Status != 0)
                {
                    Url += $"&status={filterObj.Status}";
                }
                return Json(new { status = true, redirect = Url });

            }
            catch
            {
                return Json(new { status = false, redirect = Url });

            }

        }
        // GET: Admin/Product/Details/5
        public ActionResult Details(int id)
        {
            var product = _prodRepo.Get(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // GET: Admin/Product/Create
        public IActionResult Create()
        {
            ViewBag.lsCat = new SelectList(_catRepo.GetAll(), "CatId", "CatName");
            return View();
        }
        // POST: Admin/Product/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product)
        {
            ViewBag.lsCat = new SelectList(_catRepo.GetAll(), "CatId", "CatName");
            
                var msg = _prodRepo.create(product);
                if(msg == "ok")
                {
                    var extension = Helpers.UpLoadFile.GetTypeOfFile(product.FileImage.FileName);
                    await Helpers.UpLoadFile.UploadFile(product.FileImage, "product", "ITEM" + product.ProductId.ToString() + extension);
                    _notyf.Success("Create product success");
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    _notyf.Error(msg);
                    return View(product);
                }
        }

        // GET: Admin/Product/Edit/5
        public IActionResult Edit(int id)
        {
            ViewBag.lsCat = new SelectList(_catRepo.GetAll(), "CatId", "CatName");

            var product = _prodRepo.Get(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Admin/Product/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,Product product)
        {
            ViewBag.lsCat = new SelectList(_catRepo.GetAll(), "CatId", "CatName");

                var msg = _prodRepo.update(id,product);
                if (msg == "ok")
                {
                    if(product.UpdateImage != null)
                    {
                        var extension = Helpers.UpLoadFile.GetTypeOfFile(product.UpdateImage.FileName);
                        await Helpers.UpLoadFile.UploadFile(product.UpdateImage, "product", "ITEM" + id.ToString() + extension);
                    }
                    _notyf.Success("Edit product success");
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    _notyf.Error(msg);
                    return View(product);
                }
           
        }

        // GET: Admin/Product/Delete/5
        public IActionResult Delete(int id)
        {
            var product = _prodRepo.Get(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Admin/Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public  IActionResult DeleteConfirmed(int id)
        {
             _prodRepo.delete(id);
            _notyf.Warning("Delete product success");
            return RedirectToAction(nameof(Index));
        }
        public IActionResult RemoveList(int page = 1)
        {
            var lsProduct = _prodRepo.GetAllRemove();
            var pageSize = 10;
            PagedList<Product> models = new PagedList<Product>(lsProduct.AsQueryable(), page, pageSize);
            return View(models);
        }
        public IActionResult Restone(int id)
        {
            _prodRepo.restone(id);
            _notyf.Success("Restone product success");
            return RedirectToAction(nameof(Index));
        }
        public IActionResult UpdateQuantity(int id)
        {
            var product = _prodRepo.Get(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
        [HttpPost]
        public IActionResult UpdateQuantity(int id, Product productUp)
        {
            var msg = _prodRepo.updateQuantity(id, productUp.QuantityMore);
            if(msg == "ok")
            {
                _notyf.Success("Update quantity product success");
                return RedirectToAction("Index");
            }
            _notyf.Error("Update quantity product failed");
            return View(productUp);
        }
    }
}
