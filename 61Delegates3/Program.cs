using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61Delegates3
{
    class Program
    {
        delegate void Del();
        static void Main(string[] args)
        {

            // unicast delegate - points one method at any point of time
            // multicast delegate - can point to multiple methods
            Del d = new Del(Display);
            d += Show;
            d += Output;
            d += Show;
            d -= Show;
            d();
        }

        public static void Display()
        {
            Console.WriteLine("Display method");
        }

        public static void Show()
        {
            Console.WriteLine("Show method");
        }

        public static void Output()
        {
            Console.WriteLine("Output method");
        }
    }
}
