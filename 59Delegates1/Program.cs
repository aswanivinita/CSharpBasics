using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _59Delegates1
{
    class Program
    {
        delegate int Calculator(int a, int b);
        static void Main(string[] args)
        {
            Calculator c = new Calculator(Add);
            Console.WriteLine(c(10, 20));
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
    }


}
