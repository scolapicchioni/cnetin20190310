using System;
using System.Collections.Generic;

namespace Demo10.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank b = new Bank();
            GoldAccount ga = b.OpenAccount<GoldAccount>();
            
            
        }
    }
}
