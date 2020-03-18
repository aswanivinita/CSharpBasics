using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();
            Console.WriteLine("Enter 5 names");
            for (int i = 0; i < 5; i++)
            {
                d[i] = Console.ReadLine();
            }

            Console.WriteLine("Enter names are");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(d[i]);
            }
        }
    }

    class Demo
    {
        private string[] names = new string[5];

        public string this[int index]
        {
            set { names[index] = value; }
            get { return names[index]; }
        }
    }

}
