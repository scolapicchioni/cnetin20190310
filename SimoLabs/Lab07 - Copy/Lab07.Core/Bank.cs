using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07.Core
{
    public class Bank
    {
        public Bank(string name)
        {
            Name = name;
        }
        public BankAccount[] accounts = new BankAccount[100];
        public int Counter { get; set; }

        public decimal Total {
            get {
                decimal tot = 0;
                for (int i = 0; i < Counter; i++)
                {
                    tot += accounts[i].Balance;
                }
                return tot;
            }
        }

        public string Name { get; set; }
        public BankAccount OpenAccount(AccountTypes type) {
            BankAccount newAccount = new BankAccount(Name + (Counter+1), this);
            accounts[Counter++] = newAccount;
            return newAccount;
        }

        public void Transfer(BankAccount source, BankAccount target, decimal amount) {
            source.Withdraw(amount);
            target.Deposit(amount);
        }
    }
}
