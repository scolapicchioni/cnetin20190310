using System;
using System.Collections.Generic;
using System.Text;

namespace Demo05.ConsoleApp
{
    public class MySystem
    {
        public void Work(BaseClass component) {
            //component.RealMethod();
            //component.VirtualMethod();
            component.AbstractMethod();
        }
    }
}
