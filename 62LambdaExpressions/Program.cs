using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62LambdaExpressions
{
    delegate int Calculator(int num1, int num2);
    delegate int Square(int num1);
    delegate string Upper(string str);
    class Program
    {

        static void Main(string[] args)
        {
            //Calculator c = delegate (int num1, int num2) { return num1 + num2; };
            //Calculator c =  (int num1, int num2)=> { return num1 + num2; };
            //Calculator c = ( num1,num2) => { return num1 + num2; };
            Calculator c = (num1, num2) => num1 + num2;
            Console.WriteLine(c(2, 3));

            Square s = num1 => num1 * num1;
            Console.WriteLine(s(2));

            Upper u = str => str.ToUpper();
            Console.WriteLine(u("hello world"));

        }
    }
}