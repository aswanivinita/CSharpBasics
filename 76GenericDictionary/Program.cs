using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _76GenericDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> cities = new Dictionary<int, string>();

            cities.Add(1, "Bhopal");
            cities.Add(2, "Indore");
            cities.Add(3, "Raipur");


            foreach(KeyValuePair<int, string> item in cities)
            {
                Console.WriteLine(item.Key +"\t"+ item.Value  );
            }
        }
    }
}
