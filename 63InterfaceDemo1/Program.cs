using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _63InterfaceDemo1
{
    interface IShow
    {
        void Show();
    }

    interface IDisplay
    {
        void Display();
    }
    class Program
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();
            d.Show();
            d.Display();

            IShow show = new Demo();
            show.Show();

            ((IDisplay)show).Display();
        }
    }

    class Demo: IShow,IDisplay
    {
        public void Show()
        {
            Console.WriteLine("Show Method");
        }

        public void Display()
        {
            Console.WriteLine("Display Method");
        }
    }
}
