using System;

namespace Demo05.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            MySystem system = new MySystem();
            //BaseClass bc = new BaseClass();

            SubClass01 sc01 = new SubClass01();

            system.Work(sc01);

            Console.ReadLine();
        }
    }
}
