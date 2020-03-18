using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _72GenericsDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            double da = 23.12, db = 43.53;
            Console.WriteLine("Before swap method call");
            Console.WriteLine($"a : {a}\tb : {b}");
            Swap(ref a, ref b);
            Console.WriteLine("After swap method call");
            Console.WriteLine($"a : {a}\tb : {b}");

            Console.WriteLine("Before swap method call");
            Console.WriteLine($"da : {da}\tdb : {db}");
            Swap(ref da, ref db);
            Console.WriteLine("After swap method call");
            Console.WriteLine($"da : {da}\tdb : {db}");
        }

        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        //public static void Swap(ref int a, ref int b)
        //{
        //    int temp = a;
        //    a = b;
        //    b = temp;
        //}

        //public static void Swap(ref double a, ref double b)
        //{
        //    double temp = a;
        //    a = b;
        //    b = temp;
        //}
    }
}
