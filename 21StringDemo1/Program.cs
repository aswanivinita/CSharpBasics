using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21StringDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //to reverse a string
            
            string s1 = "Demo";
            for (int i = s1.Length - 1; i >= 0; i--)
            {
                Console.Write(s1[i]);
            }
            Console.WriteLine();


            //"one two three" = "three two one"

            string s2 = "one two three";
            string[] words = s2.Split(' ');

            Console.WriteLine(words.Length);
            
            for(int i = words.Length-1; i>=0; i-- )
            {
                Console.Write(words[i]+" " );
            }
            Console.WriteLine();




            //count the number of words in string without using string length function
            Console.WriteLine("Please enter a string");
            string s3 = Console.ReadLine();
            Console.WriteLine(s3);

            int count = 0;
            char[] characters = s3.ToCharArray();

            //for(int i =0; i<characters.Length; i++ )
            //{
            //    count++;
            //}

            foreach (var item in characters)
            {
                count++;
            }

            Console.WriteLine(count);
                     
        }
    }
}
