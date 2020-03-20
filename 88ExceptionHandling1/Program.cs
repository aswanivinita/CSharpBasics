using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _88ExceptionHandling1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {4,0 };

            try
            {
                Console.WriteLine(array[0] / array[1]);
                Console.WriteLine(array[2]);

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Within the divide by zero exception block");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Within the index out of range exception block");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Program ended normally");
        }
    }
}
