using System;
using Xunit;

namespace Demo02.ConsoleApp.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void LengthOfAnInputShouldReturnTheLengthOfTheInput()
        {
            //arrange (given)
            string argument = "abcde";
            int expected = 5;

            //act (when)
            int actual = Program.LengthOfAnInput(argument);

            //assert (then)
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AnotherTest() {

        }
    }
}
