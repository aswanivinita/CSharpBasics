using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49ProtectedKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.Display();

            B b = new B();
            b.Show();
        }
    }

    class A
    {
        private void Print()
        {
            Console.WriteLine("private Print method");
        }

        public void Display()
        {
            Console.WriteLine("public Display method");
        }

        protected void Output()
        {
            Console.WriteLine("protected Output method");
        }
    }

    class B : A
    {
        public void Show()
        {
            Console.WriteLine("Show method in class B");
            // Print();
            Display();
            Output();
        }
    }

}
