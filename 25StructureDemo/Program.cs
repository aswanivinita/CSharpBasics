using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25StructureDemo
{
    struct Book
    {
        public string title;
        public string author;
        public int price;
        public string publisher;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.title = "Let us C";
            book.author = "Yashwanth kanetkar";
            book.price = 250;
            book.publisher = "bpb publications";

            Console.WriteLine($"Title : {book.title}");
            Console.WriteLine($"Author : {book.author}");
            Console.WriteLine($"Price : {book.price}");
            Console.WriteLine($"Publisher : {book.publisher}");
        }
    }
}