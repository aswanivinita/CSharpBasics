﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04ArithmeticOperator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter two numbers");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int sum = a + b;
            Console.WriteLine("Sum" +sum);
        }

    }
}
