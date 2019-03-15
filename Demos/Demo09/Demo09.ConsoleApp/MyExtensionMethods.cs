using System;
using System.Collections.Generic;
using System.Text;

namespace Demo09.ConsoleApp
{
    static class MyExtensionMethods
    {
        public static List<Car> Filter(this List<Car> originalList, Func<Car, bool> Check)
        {
            List<Car> result = new List<Car>();
            foreach (Car car in originalList)
            {
                if (Check(car))
                {
                    result.Add(car);
                }
            }
            return result;
        }
    }
}
