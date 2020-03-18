using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Console.WriteLine("Addition is :" +calc.Addition(5,2));

            Console.WriteLine("Subtraction is :" +calc.Subtraction(5, 2));
            
            Console.WriteLine("Multilication is :" +calc.Multiply(5,2));
            
            Console.WriteLine("Division is:" + calc.Division(5, 2));


        }
    }


    class Calculator
    {
        public int Addition(int number1, int number2)
        { 
       
            return (number1 + number2);
        }

        public int Subtraction(int number1, int number2)
        {
            return (number1 - number2);
        }

        public int Multiply(int number1, int number2)
        {
            return (number1 * number2);
        }

        public double Division(double number1, double number2)
        {
            return (number1 / number2);
        }

        

    }
}
