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
using Microsoft.AspNetCore.Authorization;

namespace DeliFood.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]

    public class OrderController : Controller
    {
        private IOrderRepostiory _orderRepo;
        private INotyfService _notyf;

        public OrderController(IOrderRepostiory orderRepo, INotyfService notyf)
        {
            _orderRepo = orderRepo;
            _notyf = notyf;
        }
        // GET: Admin/Order
        public  IActionResult Index(int? page = null, string idbill = null, float? from = null, float? to = null)
        {
            var lsOrder = _orderRepo.GetAll().OrderByDescending(x=> x.OrderDate).ToList();
            if(idbill != null)
            {
                lsOrder = lsOrder.Where(x => x.OrderId == int.Parse(idbill)).ToList();
                ViewBag.idFilter = idbill;

            }
            if (from != null)
            {
                lsOrder = lsOrder.Where(x => x.TotalPrice >= from).ToList();
                ViewBag.fromFilter = from;

            }
            if (to != null)
            {
                lsOrder = lsOrder.Where(x => x.TotalPrice <= to).ToList();
                ViewBag.toFilter = to;
            }
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pageSize = 10;
            PagedList<Order> models = new PagedList<Order>(lsOrder.AsQueryable(), pageNumber, pageSize);
            return View(models);
        }

        [HttpPost]
        public IActionResult Filter(string idbill = null, string from = null , string to = null)
        {
            try
            {
                // cú pháp ?dept=...&create=...
                string Url = $"/Admin/Order?page=1";

                if (!string.IsNullOrEmpty(idbill))
                {
                    Url += $"&idbill={idbill}";
                }

                if (!string.IsNullOrEmpty(from))
                {
                    Url += $"&from={from}";
                }
                if (!string.IsNullOrEmpty(to))
                {
                    Url += $"&to={to}";
                }
                return Json(new { status = true, redirect = Url });

            }
            catch
            {
                return Json(new { status = false, redirect = Url });

            }

        }
        public IActionResult ChangeVAT()
        {
            return View(_orderRepo.getCurVAT());
        }
        [HttpPost]
        public IActionResult ChangeVAT(VAT newVAT)
        {
            _orderRepo.updateVAT(newVAT.CurrentVAT.ToString());
            _notyf.Success("Update VAT success");
            return View();
        }

        // GET: Admin/Order/Edit/5
        public IActionResult Edit(int id)
        {
            var order = _orderRepo.getOrder(id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }
        [HttpPost]
        public IActionResult Edit( Order order)
        {
            string msg = _orderRepo.editStatus(order.OrderId, order.Status);
            if(msg == "ok")
            {
                _notyf.Success("Update status for bill succeeded");
                return RedirectToAction("Index");
            }
            _notyf.Error(msg);
            return View(order);
        }

    }
}
