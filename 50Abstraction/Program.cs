using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            // Animal a = new Animal();
            Mammal m = new Mammal();
            m.Move();
            Birds b = new Birds();
            b.Move();
        }
    }

   abstract class  Animal
    {
        public abstract void Move();
    }

    class Mammal:Animal
    {
        public override void Move()
        {
            Console.WriteLine("Mammal move by walking and running");
        }
    }

    class Birds:Animal
    {
        public override void Move()
        {
            Console.WriteLine("Birds move by flying");
        }
    }
}
