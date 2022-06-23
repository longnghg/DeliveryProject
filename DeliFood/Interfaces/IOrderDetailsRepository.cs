using System;
using System.Collections.Generic;
using DeliFood.Models;

namespace DeliFood.Interfaces
{
    public interface IOrderDetailsRepository
    {
        IList<OrderDetail> GetDetails(int id);
    }
}
