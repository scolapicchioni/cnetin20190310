using System;

namespace Lab06.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Ex02();

            Console.ReadLine();
        }

        static void Ex02() {
            int[,] matrix= FillArray(3, 3);
            PrintMatrix(matrix);
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write(matrix[r,c].ToString().PadLeft(3));
                }
                Console.WriteLine();
            }
        }

        /*
         * 1.	Write a program that reads ten integer numbers 
         * from the console and next calculates the sum of these numbers. 
         * Store the numbers in an array. 
         * */

        public static int Sum(int[] list) {
            int tot = 0;
            foreach (int item in list)
            {
                tot += item;
            }
            return tot;
        }

        public static void Ex01() {
            int[] numbers = new int[10];
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = AskUser($"Please enter number {i + 1}: ");
            }
            Console.WriteLine("The sum is: " + Sum(numbers));
        }

        private static int AskUser(string msg)
        {
            int res;
            bool ok;
            do
            {
                Console.Write(msg);
                string ui = Console.ReadLine();
                ok = int.TryParse(ui, out res);
            } while (!ok);
            return res;
        }

        public static int[,] FillArray(int rows, int cols)
        {
            Random random = new Random();
            int[,] res = new int[rows, cols];
            bool[] extracted = new bool[rows * cols];
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    int num = 0;
                    do
                    {
                        num = random.Next(1, (rows * cols) + 1);
                    } while (extracted[num - 1]);
                    extracted[num - 1] = true;
                    res[r, c] = num;
                }
            }
            return res;
        }
    }
}
