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
using PagedList.Core;
using Microsoft.AspNetCore.Authorization;

namespace DeliFood.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]

    public class CustomerController : Controller
    {
        private  ICustomerRepository _cusRepo;
        private INotyfService _notyf { get; }


        public CustomerController(ICustomerRepository cusRepo, INotyfService notyf)
        {
            _cusRepo = cusRepo;
            _notyf = notyf;
        }

        // GET: Admin/Customer
        public  IActionResult Index(int? page = null)
        {
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var lsCustomer = _cusRepo.GetAll(); 
            var pageSize = 10;
            PagedList<Customer> models = new PagedList<Customer>(lsCustomer.AsQueryable(), pageNumber, pageSize);
            return View(models);
        }

        // GET: Admin/Customer/Details/5
        public  ActionResult Details(int id)
        {
            var customer = _cusRepo.Get(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        public ActionResult Edit(int id)
        {
            var customer = _cusRepo.Get(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }
        [HttpPost]
        public ActionResult Edit(Customer  newcus)
        {
            string msg = _cusRepo.update(newcus.CustomerId, newcus);
            if(msg == "samephone")
            {
                ViewBag.SamePhone = "The phone is exists please choose other";
                _notyf.Warning("The phone already existed");
                return View(newcus);
            }
            if(msg == "ok")
            {
                _notyf.Success("Edit customer succeeded");
                return RedirectToAction("Index");
            }
            _notyf.Error(msg);
            return View(newcus);
        }

    }
}
