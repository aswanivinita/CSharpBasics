using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48MethodOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.Print();
            a = new B();
            a.Print();
            a = new C();
            a.Print();
            B b = new B();
            b.Print();
            b.Output();
        }
    }

    class A
    {
        public virtual void Print()
        {
            Console.WriteLine("Print method in class A");
        }
    }

    class B : A
    {
        public override void Print()
        {
            Console.WriteLine("Print method in class B");
        }

        public void Output()
        {
            Console.WriteLine("Output method in class B");
        }
    }

    class C : B
    {

        public override void Print()
        {
            Console.WriteLine("Print method in class C");
        }
    }
}
