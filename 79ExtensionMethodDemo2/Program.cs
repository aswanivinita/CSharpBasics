using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _79ExtensionMethodDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "C# is a high level programming language. Is it better then Python? C#, VB, F# are .Net programming languages.";
            Console.WriteLine(str.WordsCount());
            Console.WriteLine("str character count without spaces:" +str.TotalCharsWithoutSpace());
            string str2 = "I am learning c#";
            Console.WriteLine(str2.Length);
            Console.WriteLine("str character count without spaces:" + str2.TotalCharsWithoutSpace());

        }


    }

    static class StringExtensions
    {
        public static int WordsCount(this string s)
        {
            //string[] words = s.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries);
            //return words.Length;

            return s.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }


        public static int TotalCharsWithoutSpace(this string s)
        {
            string[] words = s.Split(' ');
            int count = 0;

            foreach(string word in words)
            {
                count += word.Length; 
            }

            return count;
        }
    }
}
