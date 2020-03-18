using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24EnumsDemo2
{
    enum Branch:short
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
            Branch b = Branch.CS;
            Console.WriteLine(b);

            Console.WriteLine("Available values in Branch type");
            foreach (var item in Enum.GetNames(typeof(Branch)))
            {
                Console.WriteLine(item);
            }
        }
    }
}
