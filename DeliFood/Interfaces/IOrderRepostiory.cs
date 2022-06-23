using System;
using System.Collections.Generic;
using DeliFood.Models;

namespace DeliFood.Interfaces
{
    public interface IOrderRepostiory
    {
        IList<Order> GetAll();
        IList<Order> GetAllofCustomer(int idCustomer);
        string create(List<CartItem> cart,string note,int idcustomer);
        bool isvalidVAT(string value);
        void updateVAT(string newVAT);
        VAT getCurVAT();
        string editStatus(int id,bool status);
        Order getOrder(int id);
    }
}
