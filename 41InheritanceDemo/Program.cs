using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            b.Print();
            b.Display();
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
}
