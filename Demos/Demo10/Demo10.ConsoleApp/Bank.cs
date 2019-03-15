using System;
using System.Collections.Generic;
using System.Text;

namespace Demo10.ConsoleApp
{
    public class Bank
    {
        public string Name { get; set; }

        public List<BankAccount> accounts = new List<BankAccount>();

        //OpenAccount<GoldAccount>()
        public TypeOfTheAccountToOpen OpenAccount<TypeOfTheAccountToOpen>() 
            where TypeOfTheAccountToOpen : BankAccount, new() {
            TypeOfTheAccountToOpen account = new TypeOfTheAccountToOpen();
            accounts.Add(account);
            return account;
        }

    }
}
