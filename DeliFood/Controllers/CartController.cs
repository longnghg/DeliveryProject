using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreHero.ToastNotification.Abstractions;
using DeliFood.Helpers;
using DeliFood.Interfaces;
using DeliFood.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeliFood.Controllers
{
    public class CartController : Controller
    {
        private IProductRepository _proRepo;
        private IOrderRepostiory _orderRepo;
        private ICustomerRepository _cusRepo;
        public INotyfService _notyf { get; }
        public CartController(INotyfService notyf, IProductRepository proRepo, IOrderRepostiory orderRepo, ICustomerRepository cusRepo)
        {
            _notyf = notyf;
            _proRepo = proRepo;
            _orderRepo = orderRepo;
            _cusRepo = cusRepo;
        }
        public List<CartItem> Cart
        {
            get
            {
                var gh = HttpContext.Session.Get<List<CartItem>>("Cart");
                if(gh == null)
                {
                    gh = new List<CartItem>();
                }
                return gh;
            }
        }
        public IActionResult AddToCart(int productID,  int? amount)
        {
            try
            {
                List<CartItem> currentCart = Cart;
                // adđ

                CartItem item = currentCart.Where(x => x.ProductId == productID).FirstOrDefault();
                if (item != null)
                {
                    if (amount.HasValue)
                    {
                        item.amount = amount.Value;
                    }
                    else
                    {
                        item.amount++;
                    }
                }
                else
                {
                    Product p = _proRepo.Get(productID);
                    item = new CartItem
                    {
                        ProductId = p.ProductId,
                        ProductName = p.ProductName,
                        Price = p.Price,
                        Image= p.Image,
                        amount = amount.HasValue ? amount.Value : 1
                    };
                    currentCart.Add(item); // Add to cart
                }
                //save session
                HttpContext.Session.Set<List<CartItem>>("Cart", currentCart);
                return Json(new { success = true , amount = currentCart.Count() });
            }
            catch 
            {
                return Json(new { success = false });

            }
        }
        public JsonResult getAmountCart()
        {

            return Json(new { amount = Cart.Count() });
        }
        public IActionResult Remove(int productID)
        {
            try
            {
                List<CartItem> currentCart = Cart;
                // adđ

                CartItem item = currentCart.Where(x => x.ProductId == productID).FirstOrDefault();
                if (item != null)
                {
                    currentCart.Remove(item);
                }

                //save session
                HttpContext.Session.Set<List<CartItem>>("Cart", currentCart);
                return Json(new { success = true , amount = currentCart.Count() });
            }
            catch
            {
                return Json(new { success = false });

            }
        }
        public IActionResult Checkout()
        {
            string idCustomer =  HttpContext.Session.GetString("idcustomer");
            if (String.IsNullOrEmpty(idCustomer))
            {
                string returnURL = "/Cart/Checkout";
                 HttpContext.SignOutAsync();
                _notyf.Warning("Please login for do payment");
                return RedirectToAction("Login", "ClientAccount",new { returnURL = returnURL });
            }
            ViewBag.Customer = _cusRepo.Get(int.Parse(idCustomer));
            List<CartItem> lsCartItem = Cart;
            return View(lsCartItem);
        }
        [HttpPost]
        public JsonResult Checkout(string note, string address)
        {
            string idCustomer = HttpContext.Session.GetString("idcustomer");
            if (String.IsNullOrEmpty(idCustomer))
            {
                HttpContext.SignOutAsync();
                return Json(new { success = false, islogin = false ,redirect = "/ClientAccount/Login" });
            }

            List<CartItem> lsCartItem = Cart;
            string msg = _orderRepo.create(lsCartItem, note, int.Parse(idCustomer));
            var customer = _cusRepo.Get(int.Parse(idCustomer));
            if(msg == "ok")
            {
                if(customer.Address == null && address != null)
                {
                    string msgUpdateAddress = _cusRepo.updateAddress(int.Parse(idCustomer), address);
                }
                HttpContext.Session.Remove("Cart");
                return Json(new { success = true, redirect = "/ClientAccount/Profile" });
            }
            return Json(new { success = false, islogin = true  });
        }
        public IActionResult Index()
        {
            List<CartItem> lsCartItem = Cart;
            return PartialView("_CartPartialView", lsCartItem);
        }
        public IActionResult DetailsCart()
        {
            return View();
        }
        public IActionResult DetailsCartPartialView()
        {
            ViewBag.CurrentVAT = _orderRepo.getCurVAT().CurrentVAT;
            List<CartItem> lsCartItem = Cart;
            
            return PartialView("_CartDetailsPartialView",lsCartItem);
        }
        public IActionResult IncAmount(int productID)
        {
            try
            {
                List<CartItem> currentCart = Cart;
                // adđ

                CartItem item = currentCart.Where(x => x.ProductId == productID).FirstOrDefault();
                if (item != null)
                {
                    item.amount++;
                }
                //save session
                HttpContext.Session.Set<List<CartItem>>("Cart", currentCart);
                return Json(new { success = true });
            }
            catch
            {
                return Json(new { success = false });

            }
        }
        public IActionResult DesAmount(int productID)
        {
            try
            {
                List<CartItem> currentCart = Cart;
                // adđ

                CartItem item = currentCart.Where(x => x.ProductId == productID).FirstOrDefault();
                if (item != null)
                {
                    if(item.amount > 1)
                    {
                        item.amount--;
                    }
                }
                //save session
                HttpContext.Session.Set<List<CartItem>>("Cart", currentCart);
                return Json(new { success = true });
            }
            catch
            {
                return Json(new { success = false });

            }
        }
    }
}