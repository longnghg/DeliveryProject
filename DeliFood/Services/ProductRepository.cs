using System;
using System.Collections.Generic;
using System.Linq;
using DeliFood.Interfaces;
using DeliFood.Models;

namespace DeliFood.Services
{
    public class ProductRepository : IProductRepository
    {
        DataContext _context;
        ICategoryRepository _catRepo;
        public ProductRepository(DataContext context, ICategoryRepository catRepo)
        {
            _context = context;
            _catRepo = catRepo;
        }

        public bool checkExistsProd(string name)
        {
            var prodExists = _context.Products.Where(x => x.ProductName == name).FirstOrDefault();
            if(prodExists!= null)
            {
                return true;
            }
            return false;
        }

        public string create(Product newProd)
        {
            try
            {
                var extension = Helpers.UpLoadFile.GetTypeOfFile(newProd.FileImage.FileName);
                var check = checkExistsProd(newProd.ProductName);
                if (check == false)
                {
                    int idProduct = 1;
                    if (_context.Products.ToList().Count > 0)
                    {
                        idProduct = _context.Products.Max(x => x.ProductId) + 1;
                    }
                 
                    newProd.Image = "ITEM" + idProduct.ToString() + extension;
                    newProd.IsDelete = false;
                    _context.Products.Add(newProd);
                    _context.SaveChanges();
                    return "ok";
                }
                else
                {
                    return "Product name already exists!";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public void delete(int id)
        {
            var deleteObj = Get(id);
            deleteObj.IsDelete = true;
            _context.SaveChanges();
        }

        public Product Get(int id)
        {
            return _context.Products.Where(x => x.ProductId == id).FirstOrDefault();
        }

        public IList<Product> GetAll()
        {
            return _context.Products.Where(x=> x.IsDelete == false).ToList();
        }

        public IList<Product> GetAllRemove()
        {
            return _context.Products.Where(x => x.IsDelete == true).ToList();
        }

        public void restone(int id)
        {
            var RestoneObj = Get(id);
            RestoneObj.IsDelete = false;
            _context.SaveChanges();
        }

        public string update(int id, Product upProduct)
        {
            try
            {
                if (id != 0)
                {
                    var oldProduct = Get(id);
                    if(oldProduct != null)
                    {
                        
                        oldProduct.ProductName = upProduct.ProductName;
                        oldProduct.CatId = upProduct.CatId;
                        oldProduct.Price = upProduct.Price;
                        oldProduct.UnitInStock = upProduct.UnitInStock;
                        if(upProduct.UpdateImage!= null)
                        {
                            var extension = Helpers.UpLoadFile.GetTypeOfFile(upProduct.UpdateImage.FileName);
                            oldProduct.Image = "ITEM" + id.ToString() + extension;
                        }
                        _context.SaveChanges();
                        return "ok";
                    }
                }
                return "data not received";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string updateQuantity(int id, int quantityProd)
        {
            var upPro = Get(id);
            if(upPro != null)
            {
                upPro.UnitInStock = upPro.UnitInStock + quantityProd;
                _context.SaveChanges();
                return "ok";
            }
            return "data not found";
            
        }
    }
}
