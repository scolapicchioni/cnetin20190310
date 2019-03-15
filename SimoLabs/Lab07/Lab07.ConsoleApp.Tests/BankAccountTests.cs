using System;
using Xunit;

namespace Lab07.Core.Tests
{
    public class BankAccountTests
    {
        [Fact]
        public void DepositShouldIncreaseBalance()
        {
            //arrange
            BankAccount b1 = new BankAccount("a", AccountTypes.Checkings, new Bank("a"));
            decimal initial = b1.Balance;
            decimal toDeposit = 100;
            decimal expected = initial + toDeposit;
            //act
            b1.Deposit(toDeposit);

            decimal actual = b1.Balance;
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DepositNegativeShouldNotChangeBalance()
        {
            //arrange
            BankAccount b1 = new BankAccount("a", AccountTypes.Checkings, new Bank("a"));
            decimal initial = b1.Balance;
            decimal toDeposit = -100;
            decimal expected = initial;
            //act
            //b1.Deposit(toDeposit);

            decimal actual = b1.Balance;
            //assert
            Assert.Throws<ArgumentOutOfRangeException>(() => b1.Deposit(toDeposit));
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void WithdrawLessThanBalanceOnCheckingsAccountShouldDecreaseBalance()
        {
            //arrange
            BankAccount b1 = new BankAccount("a", AccountTypes.Checkings, new Bank("a"));
            
            b1.Deposit(100);
            decimal initial = b1.Balance;
            decimal toWithdraw = b1.Balance-1;
            decimal expected = initial - toWithdraw;
            //act
            b1.Withdraw(toWithdraw);

            decimal actual = b1.Balance;
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void WithdrawMoreThanBalanceOnCheckingsAccountShouldDecreaseBalance()
        {
            //arrange
            BankAccount b1 = new BankAccount("a", AccountTypes.Checkings, new Bank("a"));
            b1.Deposit(100);
            decimal initial = b1.Balance;
            decimal toWithdraw = b1.Balance + 1;
            decimal expected = initial - toWithdraw;
            //act
            b1.Withdraw(toWithdraw);

            decimal actual = b1.Balance;
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void WithdrawLessThanBalanceOnSavingsAccountShouldDecreaseBalance()
        {
            //arrange
            BankAccount b1 = new BankAccount("a", AccountTypes.Savings, new Bank("a"));
            
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
        public void WithdrawMoreThanBalanceOnSavingsAccountShouldNotDecreaseBalance()
        {
            //arrange
            BankAccount b1 = new BankAccount("a", AccountTypes.Savings, new Bank("a"));
            
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
