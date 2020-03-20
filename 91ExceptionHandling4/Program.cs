using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _91ExceptionHandling4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 4, 0 };

            try
            {
                if (array[1] == 0)
                    throw new DivideByZeroException();
                Console.WriteLine(array[0]/ array[1]);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Program ended normally");
        }
    }
}
