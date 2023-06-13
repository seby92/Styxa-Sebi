using System;
using System.Collections.Generic;
using System.Text;

namespace interfaces
{
    internal class DemoClass : IFirstInterface, ISecondInterface
    {
        public void myMethod()
        {
            Console.WriteLine("Elso");
        }
        public void myOtherMethod()
        {
            Console.WriteLine("Masodik");
        }
    }
}
