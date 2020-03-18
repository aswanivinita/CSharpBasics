using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39StaticConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Demo.GetX());
            Demo.SetX(10);
            Console.WriteLine(Demo.GetX());
        }
    }
    }

    static class Demo
    {
        private static int x;

        static Demo()
        {
            x = 100;
        }

        public static void SetX(int num)
        {
            x = num;
        }

        public static int GetX()
        {
            return x;
        }
    }
