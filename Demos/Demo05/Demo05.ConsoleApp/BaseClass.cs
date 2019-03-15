using System;
using System.Collections.Generic;
using System.Text;

namespace Demo05.ConsoleApp
{
    public abstract class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("default constructor of BaseClass");
        }
        public void RealMethod() {
            Console.WriteLine("this is the realmethod of the Base Class");
        }

        public virtual void VirtualMethod()
        {
            Console.WriteLine("this is the virtual method of the Base Class");
        }

        public abstract void AbstractMethod();
    }
}
