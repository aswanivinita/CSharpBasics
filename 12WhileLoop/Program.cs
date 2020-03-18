using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int number = int.Parse(Console.ReadLine());

            while(number>0)
            {
                int remainder = number % 10;
                Console.Write(remainder);
                number = number / 10;
            }
            Console.WriteLine();
        }
    }
}
