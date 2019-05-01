using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceQuashed
{
    public class A
    {
        public void PrintFromBaseClass()
        {
            Console.WriteLine("Hi from base print class");
        }
    }

    public class B : A
    {
        public void ForceChildClassToPrintSomething()
        {
            Console.WriteLine("forced Hi from base class");
        }

        public void PrintFromChildClass()
        {
            Console.WriteLine("Hi from base class");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A baseclass = new B();
            baseclass.PrintFromBaseClass();
            A baseclass1 = new A();
        }
    }
}
