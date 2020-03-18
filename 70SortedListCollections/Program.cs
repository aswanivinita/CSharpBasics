using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _70SortedListCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList sList = new SortedList();

            sList.Add("WA", "Washington");
            sList.Add("BH", "Bhopal");
            sList.Add("T", true);
            sList.Add("CA", "California");
            sList.Add("MP", "Madhya Pradesh");

            Console.WriteLine(sList.Count);
            Console.WriteLine(sList.GetByIndex(1));
            Console.WriteLine(sList.GetByIndex(2));


            Console.WriteLine(sList.GetKey (2));

            Console.WriteLine(sList.ContainsKey("CA"));
            Console.WriteLine(sList.ContainsKey("NY"));

            Console.WriteLine(sList.ContainsValue("Bhopal"));
            Console.WriteLine(sList.ContainsValue("Delhi"));


            Console.WriteLine("LIst of Keys");
            foreach(object item in sList.GetKeyList())
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("LIst of Values");
            foreach (object item in sList.GetValueList())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("LIst of Keys Values");
            foreach (DictionaryEntry item in sList)
            {
                Console.WriteLine(item.Key+"\t"+item.Value);
            }

            Console.WriteLine(sList.Count);
           sList.Remove("BH");
            Console.WriteLine(sList.Count);

            Console.WriteLine("LIst of Keys Values");
            foreach (DictionaryEntry item in sList)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }

            sList.RemoveAt(0);

            Console.WriteLine(sList.Count);

            Console.WriteLine("LIst of Keys Values");
            foreach (DictionaryEntry item in sList)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }


        }
    }
}
