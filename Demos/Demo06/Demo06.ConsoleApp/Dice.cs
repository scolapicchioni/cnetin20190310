using System;
using System.Collections.Generic;
using System.Text;

namespace Demo06.ConsoleApp
{
    public class Dice : IDice
    {
        private Random randomNumberGenerator = new Random();
        public int Roll() {
            return randomNumberGenerator.Next(1, 7);
        }
    }
}
