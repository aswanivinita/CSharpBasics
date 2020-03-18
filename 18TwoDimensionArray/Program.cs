using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18TwoDimensionArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] items = new int[3, 3];

            Console.WriteLine("Enter 9 elements");
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    items[row, column] = int.Parse(Console.ReadLine());
                }
            }
            
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    Console.Write(items[row, column] + "\t");
                }
                Console.WriteLine();
            }



        }
    }
}
