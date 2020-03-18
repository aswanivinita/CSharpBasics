using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] nums = new int[3][];

            nums[0] = new int[3];
            nums[1] = new int[1];
            nums[2] = new int[2];

            Console.WriteLine("Enter 3 elements for first row");
            for (int i = 0; i < 3; i++)
            {
                nums[0][i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter 1 elements for second row");
            for (int i = 0; i < 1; i++)
            {
                nums[1][i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter 2 elements for third row");
            for (int i = 0; i < 2; i++)
            {
                nums[2][i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Output");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(nums[0][i] + "\t");
            }
            Console.WriteLine();
            for (int i = 0; i < 1; i++)
            {
                Console.Write(nums[1][i] + "\t");
            }
            Console.WriteLine();
            for (int i = 0; i < 2; i++)
            {
                Console.Write(nums[2][i] + "\t");
            }
            Console.WriteLine();
        }
    }
}
