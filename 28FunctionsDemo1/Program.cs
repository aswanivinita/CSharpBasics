using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28FunctionsDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = Add(20, 40);
            Console.WriteLine(total);
            Display("Ankpro");
            Console.WriteLine(GetDate());
            Wish();
        }

        public static int Add(int n1, int n2)
        {
            int sum = n1 + n2;
            return sum;
        }

        public static void Display(string s)
        {
            Console.WriteLine(s.ToUpper());
        }

        public static string GetDate()
        {
            return DateTime.Now.ToShortDateString();
        }

        public static void Wish()
        {
            Console.WriteLine("Good Morning");
        }

    }
}
