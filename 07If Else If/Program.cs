using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07If_Else_If
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a > b)
                Console.WriteLine("a is bigger");
            else if (b > a)
                Console.WriteLine("b is bigger");
            else
                Console.WriteLine("a and b are equal");
        }
    }
}
