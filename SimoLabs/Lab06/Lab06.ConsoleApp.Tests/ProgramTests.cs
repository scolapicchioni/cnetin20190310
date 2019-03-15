using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Lab06.ConsoleApp.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void FillArrayShouldReturnArrayWithOneOccurrenceOfEachNumber()
        {
            //arrange
            int rows = 3;
            int cols = 3;

            //act
            int[,] result = Program.FillArray(rows, cols);

            //assert
            Assert.Equal(rows, result.GetLength(0));
            Assert.Equal(cols, result.GetLength(1));

            Action<int> action = i => Assert.Single(result,i);
            
            Action<int>[] inspectors = Enumerable.Repeat(action, rows * cols).ToArray();
            Assert.Collection(result.OfType<int>(), inspectors);

        }
    }
}
