using System;

namespace Lab05.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int Greatest(int first, int second)
        {
            if (first > second)
                return first;
            else
                return second;
        }

        //public static int Greatest(int first, int second) => (first > second) ? first : second;

        

        public static string Greatest(string first, string second)
        {
            if (first.Length > second.Length)
                return first;
            else
                return second;
        }

        public static int Greatest(params int[] list)
        {
            int result = list[0];
            for (int i = 1; i < list.Length; i++)
            {
                result = Greatest(result, list[i]);
            }
            return result;
        }

        public static void Swap(ref int first, ref int second)
        {
            int temp = first;
            first = second;
            second = temp;
        }

        //public static int Factorial(int input)
        //{
        //    if (input <= 1)
        //        return 1;
        //    else
        //        return input *  Factorial(input - 1);
        //}

        public static int Factorial(int input) => (input <= 1)? 1 : input * Factorial(input - 1);
        
    }
}
