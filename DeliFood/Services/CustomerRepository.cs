using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCoreHero.ToastNotification.Abstractions;
using DeliFood.Interfaces;
using DeliFood.Models;

namespace DeliFood.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        DataContext _context;
        public CustomerRepository(DataContext context)
        {
            _context = context;
        }
        public bool checkExistsPhone(string phone)
        {
            var lsPhoneExists = _context.Customers.Where(x => x.Phone == phone).FirstOrDefault();
            if (lsPhoneExists != null)
            {
                return true;
            }
            return false;
        }

        public string create(Customer newCus)
        {
            try
            {
                var check = checkExistsPhone(newCus.Phone);
                if (check == false)
                {
                    // Làm chỗ này
                    newCus.Status = true;
                    _context.Customers.Add(newCus);
                    _context.SaveChanges();
                    return "ok";
                }
                else
                {
                    return "Phone already exists!";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Customer Get(int id)
        {
            return
            _context.Customers.Where(x => x.CustomerId == id).FirstOrDefault();
        }

        public IList<Customer> GetAll()
        {
            return
                _context.Customers.ToList();
        }

        public Customer GetCustomerByIDAccount(int idAcc)
        {
            return _context.Customers.Where(x => x.AccountID == idAcc).FirstOrDefault();
        }

        public string update(int id, Customer upCus)
        {
            try
            {
                var oldcus = Get(id);
                if(oldcus != null)
                {
                    if(oldcus.Phone != upCus.Phone)
                    {
                        var checkphone = checkExistsPhone(upCus.Phone);
                        if (checkphone == false)
                        {
                            oldcus.Phone = upCus.Phone;
                        }
                        else
                        {
                            return "samephone";
                        }
                    }
                    oldcus.Address = upCus.Address;
                    oldcus.FullName = upCus.FullName;
                    _context.SaveChanges();
                    return "ok";
                }
                return "The customer not exists";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public string updateAddress(int id, string address)
        {
            try
            {
                var cus = Get(id);
                cus.Address = address;
                _context.SaveChanges();
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
