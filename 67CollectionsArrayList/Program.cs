using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _67CollectionsArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
           
            
            Console.WriteLine(list.Count);

            list.Add(4);
            list.Add("Hello");
            list.Add(true);
            list.Add(12344566567676767);

            Console.WriteLine(list.Count);

            foreach(object item in list)
            {
                Console.WriteLine(item);
            }

            list.Remove(true);

            Console.WriteLine(list.Count);

            foreach (object item in list)
            {
                Console.WriteLine(item);
            }

            list[1] = "Bhopal";

            Console.WriteLine(list[1]);


            ArrayList cities = new ArrayList();

            cities.Add("Delhi");
            cities.Add("Goa");
            cities.Add("Indore");

            list.AddRange(cities);

            Console.WriteLine("No of elements in list are:" +list.Count);

            Console.WriteLine("******");
            foreach (object item in list)
            {
                Console.WriteLine(item);
            }


            list.Insert(5, "Raipur");

            Console.WriteLine("******");
            foreach (object item in list)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("Index of Goa is :" +list.IndexOf("Goa"));
            



        }
    }
}
