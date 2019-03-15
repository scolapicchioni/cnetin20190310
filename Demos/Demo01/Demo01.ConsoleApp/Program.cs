using System;

namespace Demo01.ConsoleApp
{

    class Program
    {

        /// <summary>
        /// This is the starting point
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //this is a one line comment
            /* this is
              a multiline
              comment
             */

            //Console.WriteLine(); //method
            Console.WriteLine("Hello World!");

            Console.CursorLeft = 5; //property
            Console.CursorTop = 10 + 4 - 7;

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Hello World, but then CYAN!");

            Console.WriteLine("What's your name?");

            //type name
            string userName; //variable declaration
            userName = "a value of type string" + "!";
            Console.WriteLine(userName);

            userName = Console.ReadLine();

            string message = "Hi " + userName + "!";
            Console.WriteLine(message);

            Console.WriteLine("How old are you?");
            string userInput;
            int age;
            userInput = Console.ReadLine();
            age = int.Parse(userInput);

            //userInput = 44;

            //age.ToString()

            long l;
            int i;
            //i = 5;

            l = long.MaxValue;
            i = (int)l; //cast

            bool b = true; //false
            char c = 'd';

            //short, int, long , ushort, uint, ulong

            //double, decimal

            //bool

            //char

            //string

            int a = ((5 + 3) * 2) / 10 % 2;

            a = 111;

            a = a + 5; //this

            a += 5; //or this

            a = a + 1;
            a += 1;

            a++;
            ++a;

            a = 5;

            //a = a + 1;
            //a2 = a;


            int a2 = a++;
            //a == 6
            //a2 == 5

            a = 5;
            int a3 = ++a;
            //a == 6
            //a2 == 6

            a2 = a;
            a = a + 1;

            a = 5;

            Console.WriteLine(a++);
            Console.WriteLine(a);

            Console.WriteLine(++a);

            bool b1 = a == 10;

            //AND, OR, NOT

            //AND &&
            // 0 0 => 0
            // 0 1 => 0
            // 1 0 => 0
            // 1 1 => 1

            //OR ||
            // 0 0 => 0
            // 0 1 => 1
            // 1 0 => 1
            // 1 1 => 1

            //NOT !
            // 0 => 1
            // 1 => 0

            //decimal d1 = 5;
            //double d2 = 5;

            message = "hi " + userName + " your age is " + age + "!";

            message = $"hi {userName.ToUpper()} your age is {age}!";


            int x1 = 5;
            int x2 = x1;
            x2++;

            ConsoleColor favoriteColor = ConsoleColor.DarkGray;
            ConsoleColor anotherColor = favoriteColor;

            DateTime myDate = DateTime.Now;
            DateTime myDate2 = myDate;

            Open("the file.txt", FileMode.Read);

            FileMode mode = FileMode.ReadWrite;

            Point p1;
            p1.X = 3;
            p1.Y = 5;
            p1.Z = 8;

            Point p2;
            p2.X = 30;
            p2.Y = 50;
            p2.Z = 80;
            p2.mode = FileMode.Read;

            Point p3 = p2;

            p3.Z++;
            p3.mode = FileMode.Write;


            if (x1 > 10)
            {
                Console.WriteLine("x1 is greater than 10");
            }
            Console.WriteLine("x1 is greater than 10");

            if (x1 > 10)
            {
                Console.WriteLine("x1 is greater than 10");
                Console.WriteLine("x1 is greater than 10");

            }
            else
                Console.WriteLine("x1 is not greater than 10");

            switch (x1)
            {
                case 3:
                    Console.WriteLine("first statement of the 3 value");
                    Console.WriteLine("first statement of the 3 value");
                    Console.WriteLine("first statement of the 3 value");
                    Console.WriteLine("first statement of the 3 value");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("first statement of the 5 value");
                    break;
                case 7:
                    Console.WriteLine("first statement of the 7 value");
                    break;
            }

            i = 0;
            while (i < 10) 
            {
                Console.WriteLine(i);
                i++;
            }

            do
            {
                Console.WriteLine("hi");
            } while (i < 10);

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            message = "abcdef";

            foreach (char letter in message) {
                Console.WriteLine(letter);
            }

            userInput = Console.ReadLine();
            try
            {
                age = int.Parse(userInput);
                Console.WriteLine("if I'm here, it's because the userInput is an int");
                return;
            }
            catch (FormatException problem)
            {
                 
                Console.WriteLine("sorry...");
            }
            catch (OverflowException)
            {

            }
            finally {

            }

            Nullable<bool> b2 = null;

            bool? b3 = true;


            
            Console.ReadLine();
        }


        static void Open(string fileName, FileMode mode) {

        }


    }
}
