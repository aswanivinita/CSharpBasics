using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53SealedClass
{
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            b.Show();
        }
    }

    class A
    {
        public virtual void Show()
        {
            Console.WriteLine("Show method in class A");
        }
    }

    sealed class B : A
    {
        public override void Show()
        {
            Console.WriteLine("Show method in class B");
        }
    }

    // Can not derive from class B as it is sealed
    //class C : B
    //{        

    //}
}
