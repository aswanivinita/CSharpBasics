using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _78ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();
            d.Show();
            d.Display();
            d.Output();
        }

        
    }

    class Demo
    {
        public void Show()
        {
            Console.WriteLine("show method");
        }

        public void Display()
        {
            Console.WriteLine("display method");
        }
    }


    static class Extension
    {
        public static void Output(this Demo d)
        {
            Console.WriteLine("output method from extension method");
        }
    }
}
