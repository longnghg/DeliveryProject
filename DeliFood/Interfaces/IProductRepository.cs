using System;
using System.Collections.Generic;
using DeliFood.Models;

namespace DeliFood.Interfaces
{
    public interface IProductRepository
    {
        IList<Product> GetAll();
        IList<Product> GetAllRemove();
        Product Get(int id);
        string create(Product newProd);
        string updateQuantity(int id, int quantityProd);
        string update(int id, Product upProd);
        void delete(int id);
        void restone(int id);
        bool checkExistsProd(string prodName);
    }
}
