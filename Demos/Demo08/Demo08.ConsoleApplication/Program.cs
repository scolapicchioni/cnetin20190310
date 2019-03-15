using System;

namespace Demo08.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount[] accounts = new BankAccount[] {
                new BankAccount() {Id = 5, Balance=3},
                new BankAccount() {Id = 4, Balance=10},
                new BankAccount() {Id = 1, Balance=7},
                new BankAccount() {Id = 2, Balance=8},
                new BankAccount() {Id = 8, Balance=2}
            };

            printAccounts(accounts);

            Array.Sort(accounts);

            printAccounts(accounts);

            Console.ReadLine();
        }

        //public static void Sort(BankAccount[] list) {
        //    //IComparable firstItem = (IComparable)list[0];
        //    //firstItem.CompareTo(list[1])
        //}

        static void printAccounts(BankAccount[] list) {
            Console.WriteLine("***********");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

    }
}
