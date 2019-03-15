using System;

namespace Lab07.Core
{
    public class BankAccount
    {
        //public BankAccount() : this(string.Empty, null)
        //{
        //    Console.WriteLine("DEFAULT constructor of a BANKACCOUNT");
        //    //AccountNumber = "";
        //    //Bank = null;
        //}

        public BankAccount(string accountNumber, Bank bank)
        {
            Console.WriteLine("constructor with 2 params of a BANKACCOUNT");
            AccountNumber = accountNumber;
            Bank = bank;
        }

        public decimal Balance { get; protected set; }
        
        public Bank Bank { get; }

        public string AccountNumber { get;  }
        public void Deposit(decimal toDeposit)
        {
            if (toDeposit < 0)
                throw new ArgumentOutOfRangeException(nameof(toDeposit), $"can't be negative");
            Balance += toDeposit;
        }

        public virtual void Withdraw(decimal toWithdraw)
        {
            if (toWithdraw < 0)
                throw new ArgumentOutOfRangeException(nameof(toWithdraw), $"can't be negative");
            
            Balance -= toWithdraw;
        }

    }
}