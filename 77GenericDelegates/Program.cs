using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _77GenericDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int, int> Add = delegate (int a, int b)
            {
                Console.WriteLine(a + b);
            };

            Add(2, 3);

            Action<int, int> Add1 = (a, b) => Console.WriteLine(a + b);
            Add1(2, 4);

            Action<string, string> Concatenate = (str1, str2) => Console.WriteLine(str1 + " " + str2);
            Concatenate("Vinita", "Aswani");


            Func<int, int, int> Add3 = (a, b) => a + b;
            Console.WriteLine(Add3(3, 4));

            Func<int, int> Square = a => a * a;
            Console.WriteLine(Square(2));

            Func<string, int> Length = str => str.Length;
            Console.WriteLine(Length("Hello"));


            Predicate<int> IsPositive = x => x >= 0;
            Console.WriteLine(IsPositive(4));

            Console.WriteLine(IsPositive(-8));

        }
    }
}
    
