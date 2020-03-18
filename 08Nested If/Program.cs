using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Nested_If
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());

            if (num >= 0)
                if (num % 2 == 0)
                    Console.WriteLine("number is positive even number");
                else
                    Console.WriteLine("number is a positive odd number");
            else
                Console.WriteLine("It is a negative number");
        }
    }
}
