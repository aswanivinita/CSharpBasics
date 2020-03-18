using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _80Linq1

{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] {34,-45,98,-21,5,45,-99 };

            IEnumerable<int> positiveNumbers = from n in numbers
                                               where n >= 0
                                               select n;

            Console.WriteLine("Positive numbers ");
             
            foreach(int n in positiveNumbers)
            {
                Console.WriteLine(n);
            }

            IEnumerable<int> negativeNumbers = from n in numbers
                                               where n < 0
                                               select n;


            Console.WriteLine("Negative Numbers");
            foreach (int n in negativeNumbers)
            {
                Console.WriteLine(n);
            }


            IEnumerable<int> oddNumbers = from n in numbers
                                          where n % 2 != 0
                                          select n;


            Console.WriteLine("Odd Numbers");

            foreach (int n in oddNumbers)
            {
                Console.WriteLine(n);
            }


            IEnumerable<int> squareOfEvenNumbers = from n in numbers
                                                   where n >= 10
                                                   where n % 2 == 0
                                                   select n*n;

            Console.WriteLine("Square of even numbers");

            foreach (int n in squareOfEvenNumbers)
            {
                Console.WriteLine(n);
            }

        }
    }
}
