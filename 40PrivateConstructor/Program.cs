using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40PrivateConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demo d = new Demo();
            Demo.d.ShowX();
        }
    }
    class Demo
    {
        // Singleton design pattern

        private int x;
        public static Demo d = new Demo();
        private Demo()
        {
            Console.WriteLine("Private constructor");
            x = 10;
        }

        public void ShowX()
        {
            Console.WriteLine("x : " + x);
        }
    }
}
