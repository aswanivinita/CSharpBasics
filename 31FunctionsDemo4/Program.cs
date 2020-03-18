using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31FunctionsDemo4
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = CalculateSI(1000, 2, 2);
            Console.WriteLine("SI is " + result);

            result = CalculateSI(1000, 2);
            Console.WriteLine("SI is " + result);

            result = CalculateSI(1000);
            Console.WriteLine("SI is " + result);

            // Named paramter
            result = CalculateSI(rateOfInterest: 4, principleAmount: 20000, time: 2);
            Console.WriteLine("SI is " + result);
        }

        // Default parameter
        public static double CalculateSI(int principleAmount, int time = 1, int rateOfInterest = 1)
        {
            double si = (principleAmount * time * rateOfInterest) / 100;
            return si;
        }
    }
}
