using System;
using System.Collections.Generic;
using DeliFood.Models;

namespace DeliFood.Interfaces
{
    public interface ICategoryRepository
    {
        IList<Category> GetAll();
        Category Get(int id);
        string create(Category newCat);
        string update(int id, Category upCat);
        bool checkExistsCat(string catname);
    }
}
