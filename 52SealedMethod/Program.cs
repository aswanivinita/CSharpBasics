using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52SealedMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            C c = new C();
            c.Show();

        }
    }

    class A
    {
        public virtual void Show()
        {
            Console.WriteLine("Show method in class A");
        }
    }

    class B : A
    {
        public sealed override void Show()
        {
            Console.WriteLine("Show method in class B");
        }
    }

    class C : B
    {
        // You are not allowed redefine show method because it is sealed
        //public override void Show()
        //{
        //    Console.WriteLine("Show method in class A");
        //}
    }
}
