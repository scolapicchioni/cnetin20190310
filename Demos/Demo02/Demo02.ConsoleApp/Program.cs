using System;
using System.Threading.Tasks;

namespace Demo02.ConsoleApp
{
    //internal
    public class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("This is the Main method");
            Method01();
            Console.WriteLine("Back in the Main method");
            SayHi(howManyTimes: 3, whom: "Simo");

            MethodWithDefaultParams(22);
            MethodWithDefaultParams();

            MethodWithLotsOfParams("", 0, false, 4, 4);

            MethodWithLotsOfDefaultParams(param3: true);

            int x;

            for (int i = 0; i < 5; i++)
            {
                Increment();
            }


            int arg1 = 5;
            Console.WriteLine(arg1);
            Change(arg1);
            Console.WriteLine(arg1);

            ChangeByRef(ref arg1);

            int result;
            if (int.TryParse("123", out result)) {

            }
            int myVariable = Double("aaaaaa");

            //Tuple
            var a = MethodWithTwoResults();
            Console.WriteLine(a.Item1);
            Console.WriteLine(a.Item2);

            var a2 = MethodWithTwoNamedResults();
            Console.WriteLine(a2.theNumber);
            Console.WriteLine(a2.theString);

            (int oneVar, string another) = MethodWithTwoNamedResults();

            Print("abc",4, 2, 7, 4, 8, 23);
            
            Console.ReadLine();
        }

        //params
        static void Print(string s, params int[] numbers) {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        //expression bodied methods

        
        static async Task<Tuple<int, string>> TheMethod() {
            return await Task.FromResult(new Tuple<int, string>(5, ""));
        }

        static (int theNumber, string theString) MethodWithTwoNamedResults()
        {
            return (5, "hi!");
        }

        static (int, string) MethodWithTwoResults() {
            return (5,"hi!");
        }

        //private
        public static int LengthOfAnInput(string input) {
            return input.Length - 1;
        }

        static int Bla()
        {
            string abc = "abgjisnljk";
            foreach (char item in abc) {

            }

            return 10;
        }

        static int Max(int[] list) => 5;

        static int Double(string param1) {
            if (param1.Length > 3)
            {
                Console.WriteLine("hi");
                return 5;
                //Console.WriteLine("here!");
            }

            return 0;
        }

        static void ChangeByRef(ref int param1) {
            Console.WriteLine(param1);
            param1++;
            Console.WriteLine(param1);
        }

        static void Change(int param1) {
            Console.WriteLine(param1);
            param1++;
            Console.WriteLine(param1);
        }

        static void Decrement() {
            counter--;
            Console.WriteLine(counter);
        }
        static int counter = 10;
        static void Increment() {
            //int counter = 0;

            counter++;
            //Program.counter
            Console.WriteLine(counter);
        }


        static void MethodWithLotsOfDefaultParams(string param1="", int param2=0, bool param3=false, int param4=42, decimal param5=0)
        {
            //Console.WriteLine()
        }

        static void MethodWithLotsOfParams(string param1, int param2, bool param3, int param4, decimal param5) {

        }

        //static void MethodWithDefaultParams(int someParameter=42) {
        //    SayHi(3);
        //}

        static void MethodWithDefaultParams(int someParameter = 42) => SayHi(3);
        
        static void SayHi(string whom, int howManyTimes)
        {
            for (int i = 0; i < howManyTimes; i++)
            {
                Console.WriteLine($"Hi {whom}");
            }
        }

        static void SayHi(int howManyTimes)
        {
            SayHi("", howManyTimes);
        }

        static void SayHi(string whom) {
            Console.WriteLine($"Hi {whom}");
        }

        static void Method01() {
            Console.WriteLine("Hi from method01");
            Method02();
            Console.WriteLine("Hi from method01");
        }

        static void Method02()
        {
            Console.WriteLine("Hi from method02");
        }
    }
}
