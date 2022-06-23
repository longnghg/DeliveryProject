using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AspNetCoreHero.ToastNotification.Abstractions;
using DeliFood.Interfaces;
using DeliFood.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeliFood.Controllers
{
    [Authorize]
    public class ClientAccountController : Controller
    {
        private IAccountRepository _accRepo;
        private ICustomerRepository _cusRepo;
        private IOrderRepostiory _orderRepo;
        private IOrderDetailsRepository _orderDetailsRepo;


        private INotyfService _notyf { get; }
        public ClientAccountController(IAccountRepository accRepo, ICustomerRepository cusrepo, IOrderDetailsRepository orderDetailsRepo,
            INotyfService notyf, IOrderRepostiory orderRepo)
        {
            _accRepo = accRepo;
            _cusRepo = cusrepo;
            _notyf = notyf;
            _orderRepo = orderRepo;
            _orderDetailsRepo = orderDetailsRepo;
        }
        public IActionResult ViewDetailsOrder(int id)
        {
            return View(_orderDetailsRepo.GetDetails(id));
        }
        public IActionResult Profile()
        {
            string idCustomer = HttpContext.Session.GetString("idcustomer");
            
            if(String.IsNullOrEmpty(idCustomer))
            {
                HttpContext.SignOutAsync();
                _notyf.Warning("Out of time please login again!");
                return Redirect("/ClientAccount/Login");
            }
            var lsOrder = _orderRepo.GetAllofCustomer(int.Parse(idCustomer)).OrderByDescending(x=> x.OrderDate);
            ViewBag.lsOrder = lsOrder;
            return View(_cusRepo.Get(int.Parse(idCustomer)));
        }
        public IActionResult ChangePassword(int idaccount)
        {
            var account = _accRepo.Get(idaccount);
            AccountVM accountVM = new AccountVM();
            accountVM.AccountId = account.AccountId;
            accountVM.Email = account.Email;
            return View(accountVM);
        }
        [HttpPost]
        public IActionResult ChangePassword(AccountVM accountUpdate)
        {

            string msg = _accRepo.updatePass(accountUpdate.AccountId, accountUpdate);
            if(msg == "ok")
            {
                _notyf.Success("Change password succeed, please login again");
                return RedirectToAction("Logout");
            }
            _notyf.Error(msg);
            return View(accountUpdate);
        }
        [AllowAnonymous]
        public IActionResult Login(string returnURL = null)
        {
            if (User.Identity.Name != null)
            {
                return NotFound();
            }
            
            if(returnURL != null)
            {
                ViewBag.returnURL = returnURL;
            }
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM accountLogin,string returnURL = null)
        {
            
            bool isSuccess = _accRepo.isLoginSuccess(accountLogin);
            if (isSuccess)
            {
                var userLogin = _accRepo.GetAccountLogin(accountLogin.Username);
                int idAccount = userLogin.AccountId;
                var customer = _cusRepo.GetCustomerByIDAccount(idAccount);
                // set session
                HttpContext.Session.SetString("idcustomer", customer.CustomerId.ToString());
                var claims = new List<Claim>();
                claims.Add(new Claim("user", customer.FullName ));
                claims.Add(new Claim(ClaimTypes.NameIdentifier, userLogin.Email));
                claims.Add(new Claim(ClaimTypes.Name, customer.FullName));
                claims.Add(new Claim(ClaimTypes.Role, userLogin.Role));
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                await HttpContext.SignInAsync(claimsPrincipal);
                _notyf.Success($"Welcome {customer.FullName} to Harmic Food");
                if(returnURL != null)
                {
                    return Redirect(returnURL);
                }
                return RedirectToAction("Index", "Home");
            }
            else
            {
                _notyf.Error("Login failed! please try again");
                return View();
            }

        }
        [AllowAnonymous]
        public IActionResult Register()
        {
            if (ViewData["RegisterFailed"] != null)
            {
                _notyf.Error("Login failed! please try again");
            }
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Register(RegisterVM registerAccount)
        {
            string msg = _accRepo.isRegisterSuccess(registerAccount);
            if (msg =="ok")
            {
                _notyf.Success("Register new account succeeded");
                return RedirectToAction("Login", "ClientAccount");
            }
            else
            {
                _notyf.Warning(msg);
                return View(registerAccount);
            }

        }


        public async Task<IActionResult> Logout()
        {
            HttpContext.Session.Clear();
            await HttpContext.SignOutAsync();
            return Redirect("/ClientAccount/Login");
        }
    }
}