using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Lab10.Core.Tests
{
    public class GoldCardTests
    {
        [Theory]
        [InlineData(10, 10, true)]
        [InlineData(10, 9, true)]
        [InlineData(10, 11, true)]
        public void PayReturnsTrue(int initialCredit, int toPay, bool expected)
        {
            GoldCard c = new GoldCard("", "", "", 1,0, initialCredit);
            bool actual = c.Pay(toPay);
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(100, 100, 10, 10)]
        [InlineData(180, 200, 10, 0)]
        [InlineData(200, 200, 10, 20)]
        [InlineData(100, 200, 10, -80)]
        public void PayChangesCredit(int initialCredit, int toPay, int discount, int expected)
        {
            GoldCard c = new GoldCard("", "", "", 1,discount, initialCredit);
            c.Pay(toPay);
            decimal actual = c.Credit;
            Assert.Equal(expected, actual);
        }
        
    }
}
