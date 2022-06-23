using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DeliFood.Models;
using DeliFood.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace DeliFood.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]

    public class OrderDetailsController : Controller
    {
        private readonly IOrderDetailsRepository _orderDetailRepo;

        public OrderDetailsController(IOrderDetailsRepository orderDetailRepo)
        {
            _orderDetailRepo = orderDetailRepo;
        }

        // GET: Admin/OrderDetails
        public IActionResult Index(int id)
        {
            var lsOrderDetails = _orderDetailRepo.GetDetails(id);
            if(lsOrderDetails.Count > 0)
                return View(lsOrderDetails);
            return NotFound();
        }


        //// GET: Admin/OrderDetails/Create
        //public IActionResult Create()
        //{
        //    ViewData["OrderId"] = new SelectList(_context.Orders, "OrderId", "OrderId");
        //    ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductName");
        //    return View();
        //}

        //// POST: Admin/OrderDetails/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("OrderDetailId,ShipDate,Quantity,Discount,TotalPrice,VAT,OrderId,ProductId")] OrderDetail orderDetail)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(orderDetail);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["OrderId"] = new SelectList(_context.Orders, "OrderId", "OrderId", orderDetail.OrderId);
        //    ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductName", orderDetail.ProductId);
        //    return View(orderDetail);
        //}

        //// GET: Admin/OrderDetails/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var orderDetail = await _context.OrderDetails.FindAsync(id);
        //    if (orderDetail == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["OrderId"] = new SelectList(_context.Orders, "OrderId", "OrderId", orderDetail.OrderId);
        //    ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductName", orderDetail.ProductId);
        //    return View(orderDetail);
        //}

        //// POST: Admin/OrderDetails/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("OrderDetailId,ShipDate,Quantity,Discount,TotalPrice,VAT,OrderId,ProductId")] OrderDetail orderDetail)
        //{
        //    if (id != orderDetail.OrderDetailId)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(orderDetail);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!OrderDetailExists(orderDetail.OrderDetailId))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["OrderId"] = new SelectList(_context.Orders, "OrderId", "OrderId", orderDetail.OrderId);
        //    ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductName", orderDetail.ProductId);
        //    return View(orderDetail);
        //}

        //// GET: Admin/OrderDetails/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var orderDetail = await _context.OrderDetails
        //        .Include(o => o.Order)
        //        .Include(o => o.Product)
        //        .FirstOrDefaultAsync(m => m.OrderDetailId == id);
        //    if (orderDetail == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(orderDetail);
        //}

        //// POST: Admin/OrderDetails/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var orderDetail = await _context.OrderDetails.FindAsync(id);
        //    _context.OrderDetails.Remove(orderDetail);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool OrderDetailExists(int id)
        //{
        //    return _context.OrderDetails.Any(e => e.OrderDetailId == id);
        //}
    }
}
