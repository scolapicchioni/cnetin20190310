using System;

namespace Lab07.Core
{
    public class BankAccount
    {
        internal BankAccount(string accountNumber, AccountTypes type, Bank bank)
        {
            AccountNumber = accountNumber;
            AccountType = type;
            Bank = bank;
        }

        public double InterestRate => Bank.InterestRates[AccountType];
        public decimal Balance { get; private set; }
        public AccountTypes AccountType { get;  }
        public Bank Bank { get; }

        public string AccountNumber { get;  }
        public void Deposit(decimal toDeposit)
        {
            if (toDeposit < 0)
                throw new ArgumentOutOfRangeException(nameof(toDeposit), $"can't be negative");
            Balance += toDeposit;
        }

        public void Withdraw(decimal toWithdraw)
        {
            if (toWithdraw < 0)
                throw new ArgumentOutOfRangeException(nameof(toWithdraw), $"can't be negative");
            if (AccountType == AccountTypes.Savings && toWithdraw > Balance)
                throw new ArgumentOutOfRangeException(nameof(toWithdraw), $"can't be more than {Balance} for a {AccountType} account");
            Balance -= toWithdraw;
        }

        public decimal YearlyInterest() => Balance * (decimal)InterestRate / 100;
    }
}