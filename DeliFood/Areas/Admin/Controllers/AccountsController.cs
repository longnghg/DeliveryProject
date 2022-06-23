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
    [Authorize(Roles ="Admin")]
    public class AccountsController : Controller
    {
        private  IAccountRepository _accountRepo;
        private INotyfService _notyf { get; }

        public AccountsController(IAccountRepository accountRepo, INotyfService notyf)
        {
            _accountRepo = accountRepo;
            _notyf = notyf;
        }

        // GET: Admin/Accounts
        public IActionResult Index(int page = 1)
        {
            var lsAccount = _accountRepo.GetAll();
            //List<SelectListItem> lsAccountStatus = new List<SelectListItem>();
            //lsAccountStatus.Add(new SelectListItem() { Text = "Active", Value = "1" });
            //lsAccountStatus.Add(new SelectListItem() { Text = "Non-Acitve", Value = "0" });
            //List<SelectListItem> lsRole = new List<SelectListItem>();
            //lsRole.Add(new SelectListItem() { Text = "Admin", Value = "Admin" });
            //lsRole.Add(new SelectListItem() { Text = "Customer", Value = "Customer" });
            //ViewBag.lsStatus = lsAccountStatus;
            //ViewBag.lsRole = lsRole;  
            var pageSize = 2;
            PagedList<Account> models = new PagedList<Account>(lsAccount.AsQueryable(), page, pageSize);
            return View(models);
        }
        ////[HttpPost]
        //public IActionResult Filter(int status, string role)
        //{
        //    try
        //    {
        //        // cú pháp ?dept=...&create=...
        //        string Url = $"/Admin/Account";
        //        int SoLanFilter = 1;

        //        if (!string.IsNullOrEmpty(filterObj.DeptName) && SoLanFilter == 1)
        //        {
        //            Url += $"?dept={filterObj.DeptName}";
        //            SoLanFilter++;
        //        }
        //        else if (!string.IsNullOrEmpty(filterObj.DeptName))
        //        {
        //            Url += $"&dept={filterObj.DeptName}";
        //            SoLanFilter++;
        //        }

        //        if (!string.IsNullOrEmpty(filterObj.CreateBy) && SoLanFilter == 1)
        //        {
        //            Url += $"?createby={filterObj.CreateBy}";
        //            SoLanFilter++;
        //        }
        //        else if (!string.IsNullOrEmpty(filterObj.CreateBy))
        //        {
        //            Url += $"&createby={filterObj.CreateBy}";
        //            SoLanFilter++;
        //        }

        //        if (!string.IsNullOrEmpty(filterObj.ContractNumber) && SoLanFilter == 1)
        //        {
        //            Url += $"?contractNum={filterObj.ContractNumber}";
        //            SoLanFilter++;
        //        }
        //        else if (!string.IsNullOrEmpty(filterObj.ContractNumber))
        //        {
        //            Url += $"&contractNum={filterObj.ContractNumber}";
        //            SoLanFilter++;
        //        }
        //        if (!string.IsNullOrEmpty(filterObj.PartnerName) && SoLanFilter == 1)
        //        {
        //            Url += $"?partner={filterObj.PartnerName}";
        //            SoLanFilter++;
        //        }
        //        else if (!string.IsNullOrEmpty(filterObj.PartnerName))
        //        {
        //            Url += $"&partner={filterObj.PartnerName}";
        //            SoLanFilter++;
        //        }
        //        if (!string.IsNullOrEmpty(filterObj.FromDate) && SoLanFilter == 1)
        //        {
        //            Url += $"?fromdate={filterObj.FromDate}";
        //            SoLanFilter++;
        //        }
        //        else if (!string.IsNullOrEmpty(filterObj.FromDate))
        //        {
        //            Url += $"&fromdate={filterObj.FromDate}";
        //            SoLanFilter++;
        //        }
        //        if (!string.IsNullOrEmpty(filterObj.ToDate) && SoLanFilter == 1)
        //        {
        //            Url += $"?todate={filterObj.ToDate}";
        //            SoLanFilter++;
        //        }
        //        else if (!string.IsNullOrEmpty(filterObj.ToDate))
        //        {
        //            Url += $"&todate={filterObj.ToDate}";
        //            SoLanFilter++;
        //        }
        //        if (!string.IsNullOrEmpty(filterObj.TypeContract) && SoLanFilter == 1)
        //        {
        //            Url += $"?type={filterObj.TypeContract}";
        //            SoLanFilter++;
        //        }
        //        else if (!string.IsNullOrEmpty(filterObj.TypeContract))
        //        {
        //            Url += $"&type={filterObj.TypeContract}";
        //            SoLanFilter++;
        //        }


        //        return Json(new { status = true, redirect = Url });

        //    }
        //    catch
        //    {
        //        return Json(new { status = false, redirect = Url });

        //    }

        //}
        // GET: Admin/Accounts/Details/5
        public IActionResult Details(int id)
        {
            var account = _accountRepo.Get(id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // GET: Admin/Accounts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Accounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(AccountVM account)
        {
            if (ModelState.IsValid)
            {
                string msg = _accountRepo.create(account);
                if ( msg == "ok")
                {
                    _notyf.Success("Create account success");
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    _notyf.Error(msg);
                    return View(account);
                }
                
            }
            _notyf.Error("Create account fail");
            return View(account);
        }

        public IActionResult Edit(int id)
        {
            var account = _accountRepo.Get(id);
            if (account == null)
            {
                return NotFound();
            }
            var accountVM = new AccountVM();
            accountVM.AccountId = id;
            accountVM.Email = account.Email;
            accountVM.Pass = "";
            
            return View(accountVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id,  AccountVM account)
        {
            if (ModelState.IsValid)
            {
                string msg = _accountRepo.updatePass(id,account);
                if (msg == "ok")
                {
                    _notyf.Success("Edit password success");
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    _notyf.Error(msg);
                    return View(account);
                }

            }
            _notyf.Error("Edit account fail");
            return View(account);
        }

        public IActionResult EditRole(int id)
        {
            var account = _accountRepo.Get(id);
            if (account == null)
            {
                return NotFound();
            }
            List<SelectListItem> lsRole = new List<SelectListItem>();
            lsRole.Add(new SelectListItem() { Text = "Admin", Value = "Admin" });
            lsRole.Add(new SelectListItem() { Text = "Customer", Value = "Customer" });
            ViewBag.Role = lsRole;
            return View(account);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditRole(int id, Account roleAcc)
        {
           
                string msg = _accountRepo.changeRole(id, roleAcc.Role);
                if (msg == "ok")
                {
                    _notyf.Success("Edit role success");
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    _notyf.Error(msg);
                    return View(roleAcc);
                }
        }

    }
}
