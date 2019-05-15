﻿using Cognizant.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cognizant.Domain.Interface.Service
{
    public interface IBankAccountService : IServiceBase<BankAccount>
    {
        IList<BankAccount> ListAccountsByLogin(string login);
        BankAccount GetAccountByNumberAccount(int numberAccount);
        void CreateAccount(decimal balance, int limit, string login);
        bool Transfer(decimal value, int numberAccount, int typeTransfer, string login, int userNumberAccount);
    }
}
