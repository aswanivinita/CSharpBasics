using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21StringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello World";
            string s2 = "Hi World";
            string s3 = "Hello World";

            if (s1 == s2)
                Console.WriteLine("s1 and s2 are equal");
            else
                Console.WriteLine("s1 and s2 are not equal");

            if (s1 == s3)
                Console.WriteLine("s1 and s3 are equal");
            else
                Console.WriteLine("s1 and s3 are not equal");

            Console.WriteLine("The 3 character in s1 is " + s1[6]);

            Console.WriteLine("o's index is " + s1.IndexOf('o'));
            Console.WriteLine("o's last index is " + s1.LastIndexOf('o'));

            Console.WriteLine("World's index is " + s1.IndexOf("World"));
            Console.WriteLine("World's last index is " + s1.LastIndexOf("World"));

            Console.WriteLine(s1.ToUpper());
            Console.WriteLine(s1.ToLower());

            Console.WriteLine(s1.Contains("World")); // returns true
            Console.WriteLine(s1.Contains("Universe")); // returns false

            Console.WriteLine(s1.StartsWith("Hello")); // returns true
            Console.WriteLine(s1.StartsWith("Hi")); // returns false


            Console.WriteLine(s1.EndsWith("World")); // returns true
            Console.WriteLine(s1.EndsWith("Universe")); // returns false

            string s4 = "      ram       ";
            Console.WriteLine("Hi " + s4);
            Console.WriteLine("Hi " + s4.TrimStart());
            Console.WriteLine(s4 + " completed the work");
            Console.WriteLine(s4.TrimEnd() + " completed the work");
            Console.WriteLine("Hi " + s4 + " How are you");
            Console.WriteLine("Hi " + s4.Trim() + " How are you");

            string s5 = "Be the first to find out about our newest offerings and hottest deals, and what’s new.";
            string[] words = s5.Split(' ');
            Console.WriteLine("NUmber of words " + words.Length);
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            string s6 = "ram";
            Console.WriteLine(s6.PadLeft(10, '#'));
            Console.WriteLine(s6.PadRight(10, '#'));

            string s7 = s6.Insert(1, "xyz");
            Console.WriteLine(s7);

            string s8 = "Be the first to find out about our technologies newest offerings and hottest deals, and what’s new.";
            s7 = s8.Insert(s8.IndexOf("technologies"), "Ankpro ");
            Console.WriteLine(s7);

            s7 = s8.Remove(s7.IndexOf("Ankpro "), 0);
            Console.WriteLine(s7);

            s7 = s7.Replace("technologies", "companies");
            Console.WriteLine(s7);




            string s9 = "Rama, Sita and Laxmana";
            string s10 = s9.Substring(s9.IndexOf("Sita"));
            Console.WriteLine(s10);

            s10 = s9.Substring(s9.IndexOf("Sita"), 4);
            Console.WriteLine(s10);



        }
    }
}
