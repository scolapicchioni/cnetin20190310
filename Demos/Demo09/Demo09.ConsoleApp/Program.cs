using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo09.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>() {
                new Car(){Id = 1, Brand = "FIAT", Name="500", Price=11000 },
                new Car(){Id = 2, Brand = "FIAT", Name="Punto", Price=15000 },
                new Car(){Id = 3, Brand = "AUDI", Name="A2", Price=21000 },
                new Car(){Id = 4, Brand = "AUDI", Name="A3", Price=31000 },
                new Car(){Id = 5, Brand = "FERRARI", Name="Enzo", Price=200000 },
                new Car(){Id = 6, Brand = "FERRARI", Name="F1", Price=110000000 }
            };

            var cheap = cars.Where(cInput => cInput.Price <= 25000);
            var ordered = cheap.OrderBy(cInput => cInput.Name);

            //cars.Where()
            //    .orderBy()
                
            foreach (var item in cheap)
            {

            }

            List<Car> fiats = FilterByBrandFIAT(cars);

            printList(fiats);

            List<Car> expensive = FilterByPrice25000(cars);

            printList(expensive);

            //List<Car> exp2 = Filter(cars, CheckIfPriceGreaterThan25000);
            List<Car> exp2 = cars.Filter(CheckIfPriceGreaterThan25000);

            printList(exp2);

            //List<Car> ANames = cars.Filter(CheckIfNameStartsWithA);

            //printList(ANames);

            List<Car> ANames = cars.Filter(c => c.Name.StartsWith("A"));

            List<Car> EvenIds = cars.Filter(c => c.Id % 2 == 0);

            Func<string, int> func = input => input.Length;


            DoSomethingWithACar aMethod = (id, name, brand) => new Car() { Id = id, Brand = brand, Price = 234456, Name = name };

            Car c = aMethod(5, "aa", "DHSBADH");

            Console.ReadLine();
        }

        delegate Car DoSomethingWithACar(int id, string name, string brand);

        static int func(string input) {
            return input.Length;
        }

        static bool CheckIfNameStartsWithA(Car c) {
            return c.Name.StartsWith("A");
        }


        static void printList(List<Car> cars) {
            Console.WriteLine("*************");
            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Id} - {car.Brand} - {car.Name} - {car.Price}");
            }
        }



        static bool CheckIfPriceGreaterThan25000(Car c) {
            return c.Price > 25000;
        }

        private static bool CheckIfBrandFIAT(Car car)
        {
            return car.Brand == "FIAT";
        }

        


        static List<Car> FilterByPrice25000(List<Car> originalList)
        {
            List<Car> result = new List<Car>();
            foreach (Car car in originalList)
            {
                if(CheckIfPriceGreaterThan25000(car))
                {
                    result.Add(car);
                }
            }
            return result;
        }


        static List<Car> FilterByBrandFIAT(List<Car> originalList) {
            List<Car> result = new List<Car>();
            foreach (Car car in originalList)
            {
                if (CheckIfBrandFIAT(car))
                {
                    result.Add(car);
                }
            }
            return result;
        }



        private static void Demo01()
        {
            string s = "abc";

            Action method = DoSomething;

            method();

            SomeMethod(DoSomething);

            Func<int> func = AFunctionThatReturnsAnInt;

            int result = func();

            AnotherMethod(AFunctionThatReturnsAnInt);

            Func<string, int> f2 = AFunctionThatReturnsAnIntAndHasAString;

            int r = f2("supercalifragilistiexpialidocious");
        }

        static void AnotherMethod(Func<int> func) {

        }

        static int AFunctionThatReturnsAnIntAndHasAString(string input)
        {
            return input.Length;
        }

        static int AFunctionThatReturnsAnInt() {
            return 3;
        }

        static void DoSomething() {
            Console.WriteLine("Doing something...");
        }

        static void SomeMethod(Action method) {
            method();
        }
    }
}
