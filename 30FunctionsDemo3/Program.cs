using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30FunctionsDemo3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            GetValue(out x);
            Console.WriteLine("X:" +x);

        }

        public static void GetValue(out int x)
        {
            x = 20;

        }
    }
}
