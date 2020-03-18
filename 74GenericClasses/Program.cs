using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _74GenericClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo<int> d1 = new Demo<int>(10);
            d1.Show();

            Demo<string> d2 = new Demo<string>("Hello");
            d2.Show();

            Demo<bool> d3 = new Demo<bool>(true);
            d3.Show();

            Demo<double> d4 = new Demo<double>(233.45);
            d4.Show();
        }


        class Demo<T>
        {
            private T item;

            public void Show()
            {
                Console.WriteLine(item);

            }

            public Demo(T i)
            {
                item = i;
            }

            
        }
        
    }
}
