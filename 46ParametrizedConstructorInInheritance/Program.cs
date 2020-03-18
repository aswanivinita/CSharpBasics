using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46ParametrizedConstructorInInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B(20,50);
            b.PrintX();
            b.DisplayY();
        }
    }

    class A
    {
        private int x;

        public  A(int num)
        {
            x = num;
            Console.WriteLine("Constructor in class A");
        }
        public void PrintX()
        {
            Console.WriteLine(" X:" +x);
        }
    }

    class B:A
    {
        private int y;
        public B(int num1,int num2):base(num1)
        {
            y = num2;
            Console.WriteLine("Constructor in class B");
        }

        

        public void DisplayY()
        {
            Console.WriteLine("Y :" +y);
        }

    }
}
        
