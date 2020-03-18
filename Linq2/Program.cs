using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>() { "Bhopal", "Indore", "Katni", "Raipur", "Goa" };

            IEnumerable<string> newCities = from city in cities
                                            select city.ToUpper();

            Console.WriteLine("Cities in UpperCase");

            foreach(string city in newCities)
            {
                Console.WriteLine(city);
            }


            newCities = from city in cities
                        where city.Length > 5
                        select city;

            Console.WriteLine("City with length greater than 5");

            foreach (string city in newCities)
            {
                Console.WriteLine(city);
            }


            newCities = from city in cities
                        orderby city ascending
                        select city;

            Console.WriteLine("Cities in ascending order");

            foreach (string city in newCities)
            {
                Console.WriteLine(city);
            }


            newCities = from city in cities
                        orderby city descending
                        select city;

            Console.WriteLine("Cities in descending order");

            foreach (string city in newCities)
            {
                Console.WriteLine(city);
            }



        }
    }
}
