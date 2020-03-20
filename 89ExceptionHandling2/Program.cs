using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _89ExceptionHandling2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 4, 0 };

            try
            {
                try
                {
                    Console.WriteLine(array[2]);
                }
                catch (Exception  e)
                {
                    Console.WriteLine("Within the inner try block");
                    Console.WriteLine(e.Message);

                }
                Console.WriteLine(array[0] / array[1]);
                
               

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            Console.WriteLine("Program ended normally");
        }
    }
}
