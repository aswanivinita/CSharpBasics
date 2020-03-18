using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name"  );
            string name = Console.ReadLine();
            Console.WriteLine("Enter the number of times to be printed" );
            int number = int.Parse(Console.ReadLine());

            for (int i =1; i<= number; i++)
            {
                Console.WriteLine(name);
            }

        }
    }
}
