using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());

            if (num >= 0)
                Console.WriteLine("Positive number");
            else
                Console.WriteLine("Negative number");

        }
    }
}
