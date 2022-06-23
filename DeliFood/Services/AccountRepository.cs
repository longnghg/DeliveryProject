using System;
using System.Collections.Generic;
using System.Linq;
using DeliFood.Interfaces;
using DeliFood.Models;

namespace DeliFood.Services
{
    public class AccountRepository : IAccountRepository
    {
        private readonly DataContext _context;
        private ICustomerRepository _cusRepo;

        public AccountRepository(DataContext context, ICustomerRepository cusRepo)
        {
            _context = context;
            _cusRepo = cusRepo;
        }

        public string changeRole(int id, string Role)
        {
            try
            {
                if (id != 0)
                {
                    var oldAccount = Get(id);
                    oldAccount.Role = Role;
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

        public string create(AccountVM newAcc)
        {
            try
            {
                var check = isEmailExist(newAcc.Email);
                if (check == false)
                {
                    var newAccount = new Account();
                    newAccount.CreateDate = DateTime.Now;
                    newAccount.Email = newAcc.Email;
                    newAccount.IsActive = false;
                    newAccount.Pass = Helpers.MaHoaMD5.ToMD5(newAcc.Pass);
                    newAccount.Role = "Customer";
                    _context.Accounts.Add(newAccount);
                    _context.SaveChanges();
                    return "ok";
                }
                else
                {
                    return "Email already exists!";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Account Get(int id)
        {
            return
            _context.Accounts.Where(x => x.AccountId == id).FirstOrDefault();
            
        }

        public int GetAccountIDbyEmail(string email)
        {
            return _context.Accounts.Where(x => x.Email == email).FirstOrDefault().AccountId;
        }

        public Account GetAccountLogin(string email)
        {
            return _context.Accounts.Where(x => x.Email == email).FirstOrDefault();
        }

        public IList<Account> GetAll()
        {
            return _context.Accounts.ToList();
        }

        public bool isEmailExist(string email)
        {
            var lsEmailExists = _context.Accounts.Where(x => x.Email == email).FirstOrDefault();
            if(lsEmailExists!= null)
            {
                return true;   
            }
            return false;
        }

        public bool isLoginSuccess(LoginVM LoginAcc)
        {
            var username = LoginAcc.Username;
            var password = Helpers.MaHoaMD5.ToMD5(LoginAcc.Password);
            var isExistAccount = _context.Accounts.Where(x => x.Email == username && x.Pass == password).FirstOrDefault();
            if(isExistAccount != null)
            {
                return true;
            }
            return false;
        }

        public string isRegisterSuccess(RegisterVM registerAcc)
        {
            var checkEmail = isEmailExist(registerAcc.Username);
            var checkPhone = _cusRepo.checkExistsPhone(registerAcc.Phone);
            if (checkEmail)
            {
                return "Email already existed"; 
            }
            if (checkPhone)
            {
                return "Phone already existed";
            }
            Account newAcc = new Account();
            newAcc.CreateDate = DateTime.Now;
            newAcc.Email = registerAcc.Username;
            newAcc.IsActive = false;
            newAcc.Pass = Helpers.MaHoaMD5.ToMD5(registerAcc.Password);
            newAcc.Role = "Customer";
            _context.Accounts.Add(newAcc);
            _context.SaveChanges();
            Customer newCus = new Customer();
            newCus.AccountID = GetAccountIDbyEmail(registerAcc.Username);
            newCus.FullName = registerAcc.Fullname;
            newCus.Phone = registerAcc.Phone;
            var msgCreateCustomer = _cusRepo.create(newCus);
            if (msgCreateCustomer == "ok")
                return "ok";
            return msgCreateCustomer;
            
        }

        public string updatePass(int id ,AccountVM upAcc)
        {
            try
            {
                if (id != 0)
                {
                    var oldAccount = Get(id);
                    oldAccount.Pass = Helpers.MaHoaMD5.ToMD5(upAcc.Pass);

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
