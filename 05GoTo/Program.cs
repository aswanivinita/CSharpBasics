using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05GoTo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Goa");
            goto end;
            Console.WriteLine("Sydney");
        end:
            Console.WriteLine("London");
        }
    }
}
