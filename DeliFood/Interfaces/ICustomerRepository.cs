using System;
using System.Collections.Generic;
using DeliFood.Models;

namespace DeliFood.Interfaces
{
    public interface ICustomerRepository
    {
        IList<Customer> GetAll();
        Customer Get(int id);
        string create(Customer newCus);
        string update(int id, Customer upCus);
        bool checkExistsPhone(string phone);
        Customer GetCustomerByIDAccount(int idAcc);
        string updateAddress(int id, string address);
    }
}
