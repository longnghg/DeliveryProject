using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DeliFood.Models;
using DeliFood.Interfaces;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authorization;

namespace DeliFood.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]

    public class CategoriesController : Controller
    {
        private readonly ICategoryRepository _catRepo;
        private INotyfService _notyf { get; }

        public CategoriesController(ICategoryRepository catRepo, INotyfService notyf)
        {
            _catRepo = catRepo;
            _notyf = notyf;
        }

        // GET: Admin/Categories
        public IActionResult Index()
        {
            return View(_catRepo.GetAll());
        }

        // GET: Admin/Categories/Details/5
        public IActionResult Details(int id)
        {


            var category = _catRepo.Get(id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // GET: Admin/Categories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("CatId,CatName,Published")] Category category)
        {
            if (ModelState.IsValid)
            {
                var msg = _catRepo.create(category);
                if (msg == "ok")
                {
                    _notyf.Success("Create new success");
                    return RedirectToAction(nameof(Index));
                }
                _notyf.Error(msg);
                return View(category);
            }
            _notyf.Error("Data is not valid");
            return View(category);
        }

        // GET: Admin/Categories/Edit/5
        public IActionResult Edit(int id)
        {

            var category = _catRepo.Get(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: Admin/Categories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("CatId,CatName,Published")] Category category)
        {
            if (ModelState.IsValid)
            {
                var msg = _catRepo.update(id, category);
                if (msg == "ok")
                {
                    _notyf.Success("Edit success");
                    return RedirectToAction("Index");
                }
                else
                {
                    _notyf.Error(msg);
                    return View(category);
                }

            }
            _notyf.Error("Data is not valid");
            return View(category);
        }

    }
}
