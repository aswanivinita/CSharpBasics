using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61AnonymousMethod
{
    delegate void Del1();
    delegate void Del2(int num);
    delegate string Del3(string str);
    delegate string Del4();
    class Program
    {
        static void Main(string[] args)
        {
            Del1 d = delegate ()
            {
                Console.WriteLine("Display MEthod");
            };
            d();

            Del2 d2 = delegate (int n)
          {
              Console.WriteLine($"number is {n}");
          };
            d2(5);

            Del3 d3 = delegate (string str)
            {
                return str.ToUpper();
            };

            Console.WriteLine(d3("hello world"));

            Del4 d4 = delegate ()
            {
                return DateTime.Now.ToString();
            };
            Console.WriteLine(d4());

            int x = 10;

            Del1 d5 = delegate ()
            {
                Console.WriteLine(x);
            };
            d5();

            
        }
    }
}
