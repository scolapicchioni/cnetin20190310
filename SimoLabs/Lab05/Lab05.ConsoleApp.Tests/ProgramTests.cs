using System;
using Xunit;

namespace Lab05.ConsoleApp.Tests
{
    public class ProgramTests
    {
        /*
         * 
        Greatest(). 
        This method has 2 parameters with type int and returns the greatest of the two parameter values.
        */
        [Fact]
        public void GreatestShouldReturnTheFirstArgumentGreatestOfTheTwoIntArguments() {
            //arrange
            int smallest = 5;
            int greatest = 10;
            int expected = greatest;
            //act
            int actual = Program.Greatest(greatest, smallest);
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GreatestShouldReturnTheSecondArgumentGreatestOfTheTwoIntArguments()
        {
            //arrange
            int smallest = 5;
            int greatest = 10;
            int expected = greatest;
            //act
            int actual = Program.Greatest(greatest, smallest);
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GreatestShouldReturnTheGreatestOfTheTwoIntArguments()
        {
            //arrange
            int smallest = 10;
            int greatest = 10;
            int expected = greatest;
            //act
            int actual = Program.Greatest(greatest, smallest);
            //assert
            Assert.Equal(expected, actual);
        }

        /*

        2 Overload the Greatest method with 2 other methods:
        •	1 method with 2 parameters with type String that returns the string with the biggest length.
        */

        [Fact]
        public void GreatestShouldReturnTheFirstArgumentGreatestOfTheTwoStringArguments()
        {
            //arrange
            string shortest = "abc";
            string longest = "abcdefg";
            string expected = longest;
            //act
            string actual = Program.Greatest(longest, shortest);
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GreatestShouldReturnTheSecondArgumentGreatestOfTheTwoStringArguments()
        {
            //arrange
            string shortest = "abc";
            string longest = "abcdefg";
            string expected = longest;
            //act
            string actual = Program.Greatest(shortest, longest);
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GreatestShouldReturnTheGreatestOfTheTwoStringArguments()
        {
            //arrange
            string shortest = "abc";
            string longest = "abc";
            string expected = longest;
            //act
            string actual = Program.Greatest(longest, shortest);
            //assert
            Assert.Equal(shortest, actual);
            Assert.Equal(longest, actual);
        }

        /*
        •	1 method  with a variable-length parameter list with type int that returns the greatest of the parameters values.
        */

        [Fact]
        public void GreatestShouldReturnTheGreatestOfTheParamsArguments()
        {
            //arrange
            int smallest = 1;
            int medium = 5;
            int greatest = 10;
            int expected = greatest;
            //act
            int actual = Program.Greatest(smallest, greatest, medium);
            //assert
            Assert.Equal(expected, actual);
        }

        /*
        3. Add a method called Swap. This method has 2 parameters with type int. 
        The method should exchange the two parameter values.
        */
        [Fact]
        public void SwapShouldSwapTheArguments()
        {
            //arrange
            int first = 1;
            int second = 5;

            int expectedFirst = second;
            int expectedSecond = first;

            //act
            Program.Swap(ref first, ref second);
            //assert
            Assert.Equal(expectedFirst, first);
            Assert.Equal(expectedSecond, second);
        }

        /*
        4. Add a method called Factorial with a parameter of type in.
        The method calculates the factorial. 
        Use a recursive algorithm.
        Factorial:
        n! = n * (n-1) * (n-2) *.......*1
        (5! = 5 * 4!)
        E.g.: 
        5! = 5*4*3*2*1 = 120  
        */
        [Fact]
        public void FactorialShouldReturnTheFactorialOfTheInput()
        {
            //arrange
            int input = 5;
            int expected = 120;

            //act
            int actual = Program.Factorial(input);
            
            //assert
            Assert.Equal(expected, actual);
        }

    }
}
