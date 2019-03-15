using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Lab07.Core.Tests
{
    public class BankTests
    {
        [Fact]
        public void TransferShouldTransferBalanceFromOneAccountToTheOther() {
            BankAccount s = new BankAccount("a", AccountTypes.Checkings, new Bank("a"));
            BankAccount t = new BankAccount("a", AccountTypes.Checkings, new Bank("a"));
            Bank bank = new Bank("bank");
            decimal initial = 100;
            decimal toTransfer = 30;
            s.Deposit(initial);
            t.Deposit(initial);
            bank.Transfer(s, t, toTransfer);
            Assert.Equal(initial - toTransfer, s.Balance);
            Assert.Equal(initial + toTransfer, t.Balance);
        }

        [Fact]
        public void TotalShouldReturnTheSumOfAllBalances() {
            Bank bank = new Bank("bank");
            BankAccount b1 = bank.OpenAccount(AccountTypes.Checkings);
            BankAccount b2 = bank.OpenAccount(AccountTypes.Checkings);
            BankAccount b3 = bank.OpenAccount(AccountTypes.Checkings);
            b1.Deposit(100);
            b2.Deposit(100);
            b3.Deposit(100);
            Assert.Equal(b1.Balance + b2.Balance + b3.Balance, bank.Total);
        }
    }
}
