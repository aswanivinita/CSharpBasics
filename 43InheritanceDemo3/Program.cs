using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43InheritanceDemo3
{
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            C c = new C();

            b.Print();
            b.Display();

            c.Print();
            c.Output();
        }
    }

    class A
    {
        public void Print()
        {
            Console.WriteLine("print method in class A");
        }
    }

    class B : A
    {
        public void Display()
        {
            Console.WriteLine("display method in class B");

        }
    }

    class C : A
    {
        public void Output()
        {
            Console.WriteLine("output method in class C");
        }
    }
}
