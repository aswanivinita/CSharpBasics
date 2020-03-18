using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _73GenericsDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Show(10, 34.24f);
            Show('x', "Ram");
        }

        public static void Show<T, U>(T a, U b)
        {
            Console.WriteLine($"a = {a} and type is {typeof(T)}");
            Console.WriteLine($"b = {b} and type is {typeof(U)}");
        }
    }
}
