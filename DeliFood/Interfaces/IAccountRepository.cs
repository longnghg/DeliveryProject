using System;
using System.Collections.Generic;
using DeliFood.Models;

namespace DeliFood.Interfaces
{
    public interface IAccountRepository
    {
        IList<Account> GetAll();
        Account Get(int id);
        string create(AccountVM newAcc);
        string updatePass(int id, AccountVM upAcc);
        string changeRole(int id, string Role);
        bool isEmailExist(string email);
        int GetAccountIDbyEmail(string email);
        bool isLoginSuccess(LoginVM loginAcc);
        Account GetAccountLogin(string email);
        string isRegisterSuccess(RegisterVM registerAcc);
        
    }
}
