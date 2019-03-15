using System;

namespace Demo03.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ArrayCopy();

            Console.ReadLine();

        }

        private static void FirstDemo()
        {
            int[] listOfNumbers; //reference

            int numberOfItems = int.Parse(Console.ReadLine());

            listOfNumbers = new int[numberOfItems]; //instance

            PrintList(listOfNumbers);

            string[] italianDaysOfTheWeek = new string[] { "Lunedi", "Martedi", "Mercoledi", "Giovedi", "Venerdi", "Sabato", "Domenica" };

            for (int i = 0; i < italianDaysOfTheWeek.Length; i++)
            {
                Console.WriteLine(italianDaysOfTheWeek[i]);
            }

            Console.WriteLine(italianDaysOfTheWeek.Length);

            int[,] matrix = new int[5, 3]
            {
                { 1,2,3},
                { 6,7,8},
                { 10,11,12},
                { 44,11,22},
                {67,94,24 }
            };

            int cols = matrix.GetLength(0);
            int rows = matrix.GetLength(1);

            for (int c = 0; c < cols; c++)
            {
                for (int r = 0; r < rows; r++)
                {
                    Console.WriteLine(matrix[c, r]);
                }
            }

            int[,,] cube = new int[5, 3, 7];

            int[] anotherList = new int[100];
        }

        private static void ArrayCopy()
        {
            int[] firstList = new int[] { 1, 2, 3, 4, 5 };

            int[] secondList = firstList;

            secondList[0] = 999;



            Console.WriteLine(firstList[0]);

            ChangeListItem(firstList);

        }

        static void ChangeListItem(int[] list) {
            list[0] = 12345;
        }

        static void PrintList(int[] list) {
            Console.WriteLine($"The length is {list.Length}");
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine($"The item at position {i} is equal to {list[i]}");
            }
            Console.WriteLine("*************");
            foreach (int item in list)
            {
                Console.WriteLine($"Item: {item}");
            }
        }
    }
}
