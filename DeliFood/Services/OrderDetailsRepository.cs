using System;
using System.Collections.Generic;
using System.Linq;
using DeliFood.Interfaces;
using DeliFood.Models;

namespace DeliFood.Services
{
    public class OrderDetailsRepository : IOrderDetailsRepository
    {
        private DataContext _context;
        public OrderDetailsRepository(DataContext context)
        {
            _context = context;
        }
        public IList<OrderDetail> GetDetails(int id)
        {
            return _context.OrderDetails.Where(x=> x.OrderId == id).ToList();
        }
    }
}
