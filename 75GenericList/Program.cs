using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _75GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            numbers.Add(20);
            numbers.Add(30);

            foreach(var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
