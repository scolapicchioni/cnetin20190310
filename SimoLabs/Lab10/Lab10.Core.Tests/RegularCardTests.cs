using System;
using Xunit;

namespace Lab10.Core.Tests
{
    public class RegularCardTests
    {
        [Theory]
        [InlineData(10,10,true)]
        [InlineData(10, 9, true)]
        [InlineData(10, 11, false)]
        public void PayReturnsIfAmountLessOrEqualThanCredit(int initialCredit, int toPay, bool expected)
        {
            RegularCard c = new RegularCard("", "", "", 1, initialCredit);
            bool actual = c.Pay(toPay);
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(10, 10, 0)]
        [InlineData(10, 9, 1)]
        [InlineData(10, 11, 10)]
        public void PayChangesCreditIfAmountLessOrEqualThanCredit(int initialCredit, int toPay, int expected)
        {
            RegularCard c = new RegularCard("", "", "", 1, initialCredit);
            c.Pay(toPay);
            decimal actual = c.Credit;
            Assert.Equal(expected, actual);
        }
    }
}
