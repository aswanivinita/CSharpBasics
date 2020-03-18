using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45Inheritance5
{
    class Program
    {
        static void Main(string[] args)
        {
            C c = new C();
        }
    }

    class A
    {
        public A()
        {
            Console.WriteLine("Constructor in A");
        }

        ~A()
        {
            Console.WriteLine("Destructor in A");
        }
    }





    class B:A
    {
        public B()
        {
            Console.WriteLine("Constructor in class B");
        }

        ~B()
        {
            Console.WriteLine("Destructor in B");
        }
    }


    class C : B
    {
        public C()
        {
            Console.WriteLine("Constructor in class C");
        }
        ~C()
        {
            Console.WriteLine("Destructor in C");
        }
    }
}
