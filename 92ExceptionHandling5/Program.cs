using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _92ExceptionHandling5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Demo();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Catch block in main method");

            }
            Console.WriteLine("Program ended normally");

        }

        public static void Demo()
        {
            int[] array = new int[] { 4, 0 };

            try
            {
                
                //Console.WriteLine(array[0] / array[1]);
                Console.WriteLine(array[2]);

            }
            catch (DivideByZeroException e)
            {

                Console.WriteLine(e.Message);
                Console.WriteLine("catch block in demo method");
            }

            
        }
    }
}
