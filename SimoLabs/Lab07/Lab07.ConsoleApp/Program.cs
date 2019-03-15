using Lab07.Core;
using System;

namespace Lab07.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank rabo = new Bank("Rabo");
            BankAccount b1 = rabo.OpenAccount(AccountTypes.Checkings);

            

        }
    }
}
