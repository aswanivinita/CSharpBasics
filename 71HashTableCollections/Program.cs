using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _71HashTableCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht.Add(1, "Delhi");
            ht.Add(5, "Indore");
            ht.Add(3, "Raipur");

            Console.WriteLine(ht.Count);
            ht.Remove(1);
            
            foreach(DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key+"\t" +item.Value);
            }

            foreach(object item in ht.Keys)
            {
                Console.WriteLine(item);
            }

            foreach (object item in ht.Values)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(ht.ContainsKey(5));
            Console.WriteLine(ht.ContainsKey(10));
            Console.WriteLine(ht.ContainsValue("Delhi"));
            Console.WriteLine(ht.ContainsValue("Raipur"));
        }
    }
}
