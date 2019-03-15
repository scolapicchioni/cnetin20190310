using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07.Core
{
    public class SavingsAccount : BankAccount
    {
        //public SavingsAccount() : base("",new Bank(""))
        //{
        //    Console.WriteLine("DEFAULT constructor of SAVINGSACCOUNT");
        //}

        public SavingsAccount(string accNumber, int interest, Bank bank) : base(accNumber, bank)
        {
            Console.WriteLine("Contructor with 2 PARAMS of SAVINGSACCOUNT");
            InterestRate = interest;
        }

        //private string doSomething() {
        //    return "AAAAAAAAAAAAAAAAAAAA";
        //}

        public override void Withdraw(decimal toWithdraw)
        {
            if (toWithdraw > Balance)
                throw new ArgumentOutOfRangeException(nameof(toWithdraw), $"can't be more than {Balance} for a SavingsAccount account");

            base.Withdraw(toWithdraw);

        }

        public int InterestRate { get; set; }
        public decimal YearlyInterest() => Balance * (decimal)InterestRate / 100;
    }
}
