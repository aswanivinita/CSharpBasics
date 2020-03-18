using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32ClassesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();
            c1.SetRadius();
            Console.WriteLine("Area : " + c1.CalculateArea());

            Circle c2 = new Circle();
            c2.SetRadius();
            Console.WriteLine("Area : " + c2.CalculateArea());

        }
    }

    class Circle
    {
        private int radius;

        public void SetRadius()
        {
            Console.WriteLine("Enter the radius");
            radius = int.Parse(Console.ReadLine());
        }

        public double CalculateArea()
        {
            double area = 3.14 * radius * radius;
            return area;
        }
    }
}
