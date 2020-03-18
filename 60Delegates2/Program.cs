using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60Delegates2
{
    class Program
    {
        delegate int Calculator(int a, int b);
        static void Main(string[] args)
        {
            Demo d = new Demo();

            Calculator c = new Calculator(d.Mod);
            Console.WriteLine(c(24, 5));
            c = Add;
            Console.WriteLine(c(24, 5));
            c = d.Subtract;
            Console.WriteLine(c(24, 5));
            c = d.Multiply;
            Console.WriteLine(c(24, 5));
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }

    }


    class Demo
    {
        public int Mod(int a, int b)
        {
            return a % b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }


}
