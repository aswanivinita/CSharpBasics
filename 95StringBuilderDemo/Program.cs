using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _95StringBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Hello");
            
            sb.Append("World");

            Console.WriteLine(sb);

            
        }
    }
}
