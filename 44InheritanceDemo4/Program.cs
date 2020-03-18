using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44InheritanceDemo4
{
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            C c = new C();
            D d = new D();

            b.Print();
            b.Display();
            c.Display();
            c.Print();
            c.Output();

            d.Print();
            d.Show();
            d.Display();
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

    class C : B
    {
        public void Output()
        {
            Console.WriteLine("output method in class C");
        }
    }

    class D : B
    {
        public void Show()
        {
            Console.WriteLine("show  method in class C");
        }
    }
}
