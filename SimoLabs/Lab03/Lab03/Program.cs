using System;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount savingsAccount, checkingsAccount;
            savingsAccount.AccountType = AccountType.Savings;
            checkingsAccount.AccountType = AccountType.Checkings;

            Console.WriteLine("Savings number: ");
            savingsAccount.AccountNumber = Console.ReadLine();
            Console.WriteLine("Checkings number: ");
            checkingsAccount.AccountNumber = Console.ReadLine();

            savingsAccount.Balance = -123;
            checkingsAccount.Balance = 12368349350;

            Console.WriteLine($"savings number: {savingsAccount.AccountNumber}, Balance: {savingsAccount.Balance}, Type: {savingsAccount.AccountType}");
            Console.WriteLine($"checkings number: {checkingsAccount.AccountNumber}, Balance: {checkingsAccount.Balance}, Type: {checkingsAccount.AccountType}");

            Console.ReadLine();
        }
    }
}
