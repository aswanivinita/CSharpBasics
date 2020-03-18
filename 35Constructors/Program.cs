using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo d1 = new Demo();
            d1.ShowX();

            Demo d2 = new Demo();
            d2.ShowX();

            Demo d3 = new Demo(20);
            d3.ShowX();

            Demo d4 = new Demo(560);
            d4.ShowX();

            Demo d5 = new Demo(d1);
            d5.ShowX();
        }


        class Demo
        {
            private int x;

            // Default constructor
            public Demo()
            {
                x = 10;
            }

            // Parameterized constructor
            public Demo(int num)
            {
                x = num;
            }

            // Copy constructor
            public Demo(Demo d)
            {
                x = d.x;
            }

            public void ShowX()
            {
                Console.WriteLine("x : " + x);
            }
        }




    }
}
