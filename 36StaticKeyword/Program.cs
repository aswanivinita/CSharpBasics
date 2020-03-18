using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36StaticKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo d1 = new Demo();
            Demo d2 = new Demo();

            Console.WriteLine("no of objetcs created" +Demo.GetCounter());

            Demo d3 = new Demo();
            Demo d4 = new Demo();

            Console.WriteLine("no of objetcs created" + Demo.GetCounter());




        }
    }
    class Demo
    {
        private static int counter;

        public Demo()
        {
            counter++;
        }

        public static int GetCounter()
        {
            return counter;
        }
    }
}
