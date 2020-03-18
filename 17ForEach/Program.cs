using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] nums = new int[5];
            Console.WriteLine("Enter five numbers");
            
            for (int i = 0; i < nums.Length; i++)
                nums[i] = int.Parse(Console.ReadLine());

            for (int i = 0; i < nums.Length; i++)
                sum += nums[i];

            Console.WriteLine("The sum all numbers is " + sum);

        }
    }
}
