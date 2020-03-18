using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _81Linq3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Ram", "Mohan", "Inaya", "Dhruv" };

            IEnumerable<string> newNames = from name in names
                                           where name.Length > 3
                                           select name;
           
            // LAZY LOADING OR DEFERRRED LOADING
            
            names.Add("vinita");

            names.Remove("Dhruv");

            Console.WriteLine("Names Length greater than 3 characters");

            foreach (string name in newNames)
            {
                Console.WriteLine(name);
            }

            //EAGER LOADING

            int count  =(from name in names
                         where name.Length > 3
                         select name).Count();

            //NO IMPACT TO THE COUNT VARIABLE BECAUSE OF EAGER LOADING 
            
            names.Add("Sita");
            names.Add("Gita");
            names.Remove("Inaya");

            Console.WriteLine(count);

        }
    }
}
