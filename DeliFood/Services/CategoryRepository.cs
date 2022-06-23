using System;
using System.Collections.Generic;
using System.Linq;
using DeliFood.Interfaces;
using DeliFood.Models;

namespace DeliFood.Services
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataContext _context;
        public CategoryRepository(DataContext context)
        {
            _context = context;
        }

        public bool checkExistsCat(string catname)
        {
            var catExist = _context.Categories.Where(x => x.CatName == catname).FirstOrDefault();
            if (catExist != null)
                return true;
            return false;
        }

        public string create(Category newCat)
        {
            try
            {
                var check = checkExistsCat(newCat.CatName);
                if (check == false)
                {
                    newCat.Published = true;
                    _context.Categories.Add(newCat);
                    _context.SaveChanges();
                    return "ok";
                }
                else
                {
                    return "Category name already exists!";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Category Get(int id)
        {
            return
            _context.Categories.Where(x => x.CatId == id).FirstOrDefault();
        }

        public IList<Category> GetAll()
        {
            return
            _context.Categories.ToList();
        }


        public string update(int id, Category upCat)
        {
            try
            {
                if (id != 0)
                {
                    var oldCat = Get(id);
                    oldCat.CatName = upCat.CatName;
                    oldCat.Published = upCat.Published;
                    _context.SaveChanges();
                    return "ok";
                }
                return "data not received";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
