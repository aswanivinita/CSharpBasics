using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14ContinueAndBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                {
                    // break; // Exits the loop when i is equal to 3
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
