using System;
using System.Collections.Generic;
using System.Text;

namespace Demo05.ConsoleApp
{
    public class SubClass01 : BaseClass
    {
        public void RealMethod()
        {
            Console.WriteLine("this is the realmethod of the Sub Class 01");
        }

        //public override void VirtualMethod()
        //{
        //    Console.WriteLine("this is the oveeride in SubClass01 of the VirtualMethod");
        //}
        public override void AbstractMethod()
        {
            Console.WriteLine("Abstract of SUBCLASS01");
        }

        public SubClass01()
        {
            Console.WriteLine("default constructor of SubClass");
        }
    }
}
