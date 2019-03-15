using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Lab07.Core.Tests
{
    public class SavingsAccountTests
    {
        [Fact]
        public void WithdrawLessThanBalanceOnSavingsAccountShouldDecreaseBalance()
        {
            //arrange
            BankAccount b1 = new SavingsAccount("",0,null);

            b1.Deposit(100);
            decimal initial = b1.Balance;
            decimal toWithdraw = b1.Balance - 1;
            decimal expected = initial - toWithdraw;
            //act
            b1.Withdraw(toWithdraw);

            decimal actual = b1.Balance;
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void WithdrawMoreThanBalanceShouldNotDecreaseBalance()
        {
            //arrange
            BankAccount b1 = new SavingsAccount("",0,null);

            b1.Deposit(100);
            decimal initial = b1.Balance;
            decimal toWithdraw = b1.Balance + 1;
            decimal expected = initial;

            //act


            decimal actual = b1.Balance;
            //assert
            Assert.Throws<ArgumentOutOfRangeException>(() => b1.Withdraw(toWithdraw));
            Assert.Equal(expected, actual);
        }
    }
}
