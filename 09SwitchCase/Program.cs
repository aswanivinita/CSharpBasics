using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());

            //if(num==1)
            //    Console.WriteLine("Sunday");
            //else if(num==2)
            //    Console.WriteLine("Monday");
            //else if (num == 3)
            //    Console.WriteLine("Tuesday");
            //else if (num == 4)
            //    Console.WriteLine("Wednesday");
            //else if (num == 5)
            //    Console.WriteLine("Thursday");
            //else if (num == 6)
            //    Console.WriteLine("Friday");
            //else if (num == 7)
            //    Console.WriteLine("Saturday");
            //else 
            //    Console.WriteLine("Invalid input");

            switch (num)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}
