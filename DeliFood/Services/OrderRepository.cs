using System;
using System.Collections.Generic;
using System.Linq;
using DeliFood.Interfaces;
using DeliFood.Models;

namespace DeliFood.Services
{
    public class OrderRepository : IOrderRepostiory
    {
        DataContext _context;
        IProductRepository _proRepo;
        public OrderRepository(DataContext context, IProductRepository proRepo)
        {
            _context = context;
            _proRepo = proRepo;
        }

        public string create(List<CartItem> cart, string note, int idcustomer)
        {
            try
            {
                Customer cus = _context.Customers.Where(x => x.CustomerId == idcustomer).FirstOrDefault();
                if(cus != null)
                {
                    if(cus.Account.Role == "Admin")
                    {
                        return "Admin cannot buy product";
                    }
                    string noteforBill = null;
                    if(note != null)
                    {
                        noteforBill = note;
                    }
                    double totalPrice = 0;
                    foreach (var item in cart)
                    {
                        totalPrice += item.Total;
                    }
                    float VAT = getCurVAT().CurrentVAT;
                    int discount = 0;
                    Order newOrder = new Order();
                    newOrder.CustomerId = idcustomer;
                    newOrder.Note = noteforBill;
                    newOrder.Status = false;
                    newOrder.OrderDate = DateTime.Now;
                    newOrder.TotalPrice = (float)totalPrice;
                    _context.Orders.Add(newOrder);
                    _context.SaveChanges();
                    int idOrder = _context.Orders.Max(x => x.OrderId);
                    foreach (var item in cart)
                    {
                        OrderDetail orderDetails = new OrderDetail();
                        orderDetails.OrderId = idOrder;
                        orderDetails.Discount = discount;
                        orderDetails.ProductId = item.ProductId;
                        orderDetails.Quantity = item.amount;
                        orderDetails.ShipDate = DateTime.Now;
                        orderDetails.TotalPrice = (float)item.Total;
                        orderDetails.VAT = VAT;
                        _context.OrderDetails.Add(orderDetails);
                        _context.SaveChanges();
                    }
                    return "ok";

                }
                return "Customer not exists";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public string editStatus(int id,bool status)
        {
            try
            {
                var orderEdit = _context.Orders.Find(id);
                if(orderEdit != null)
                {
                    orderEdit.Status = status;
                    _context.SaveChanges();
                    return "ok";
                }
                return "Not found this order bill";

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public IList<Order> GetAll()
        {
            return _context.Orders.ToList();
        }

        public IList<Order> GetAllofCustomer(int idCustomer)
        {
            return _context.Orders.Where(x => x.CustomerId == idCustomer).ToList();
        }

        public VAT getCurVAT()
        {
            return _context.VAT.FirstOrDefault();
        }

        public Order getOrder(int id)
        {
            return _context.Orders.Find(id);
        }

        public bool isvalidVAT(string value)
        {
            float outPut;
            return float.TryParse(value, out outPut);
        }

        public void updateVAT(string newVAT)
        {
            if (isvalidVAT(newVAT))
            {
                VAT curVAT = _context.VAT.FirstOrDefault();
                curVAT.CurrentVAT = float.Parse(newVAT);
                _context.SaveChanges();
            }
        }
    }
}
