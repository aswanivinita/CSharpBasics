using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23EnumsDemo
{
    enum Branch
    {
        CS = 100,
        Auto = 200,
        Civil = 300,
        Mech = 400
    }
    class Program
    {
        static void Main(string[] args)
        {
            Branch branch = Branch.Auto;

            Console.WriteLine(branch);
            Console.WriteLine((int)branch);

            branch = (Branch)400;
            Console.WriteLine(branch);
            Console.WriteLine((int)branch);
        }
    }
}
