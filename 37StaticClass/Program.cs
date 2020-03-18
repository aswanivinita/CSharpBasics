using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo.SetX(10);
            Console.WriteLine(Demo.GetX());
        }
    }

    static class Demo
    {
        private static int x;

        public static void SetX(int num)
        {
            x = num;
        }

        public static int GetX()
        {
            return x;
        }
    }
}
