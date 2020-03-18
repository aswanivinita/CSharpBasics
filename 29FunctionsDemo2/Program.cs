using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29FunctionsDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20;

            Console.WriteLine($"Before function call : a = {a} and b = {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"After function call : a = {a} and b = {b}");
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"Within swap function : a = {a} and b = {b}");
        }
    }
}
