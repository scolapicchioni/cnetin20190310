using System;
using System.Collections.Generic;
using System.Text;

namespace Demo08.ConsoleApplication
{
    public class BankAccount : IComparable
    {
        public int Id { get; set; }
        public decimal Balance { get; set; }

        public int CompareTo(object obj)
        {
            return Id - ((BankAccount)obj).Id;
        }

        public override string ToString()
        {
            return $"Id: {Id} - Balance: {Balance}";
        }
    }
}
