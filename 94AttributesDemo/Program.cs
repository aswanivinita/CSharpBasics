using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _94AttributesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(2,3,1));
        }


        [Obsolete("As this is an outdated method use the Add method with 3 parameters" , true)]
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Add(int a, int b, int c = 0)
        {
            return a + b + c;
        }
    }
}
