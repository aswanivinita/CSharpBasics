using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Add(10, 20));
            Console.WriteLine(Add(10, 20, 30));
            Console.WriteLine(Add(10.20, 34.23));
        }


        public static int Add(int a, int b)
        {
            Console.WriteLine("Add method with 2 parameters is called");
            return a + b;
        }

        public static int Add(int a, int b, int c)
        {
            Console.WriteLine("Add method with 3 parameters is called");
            return a + b + c;
        }

        public static double Add(double a, double b)
        {
            Console.WriteLine("Add method with 2 double type parameters is called");
            return a + b;
        }

    }

}
