using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26StructureDemo2
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
            Book book = new Book() { title = "ANSI C", author = "Balaguru samy", price = 200, publisher = "Mc Grah Hill" };

            Console.WriteLine($"Title : {book.title}");
            Console.WriteLine($"Author : {book.author}");
            Console.WriteLine($"Price : {book.price}");
            Console.WriteLine($"Publisher : {book.publisher}");

            Book[] books = new Book[2];
            books[0].title = "ANSI C";
            books[0].author = "Balaguru samy";
            books[0].price = 200;
            books[0].publisher = "Mc Grah Hill";

            books[1].title = "Let us C";
            books[1].author = "Yashwant kanetkar";
            books[1].price = 200;
            books[1].publisher = "bpb publications";

            foreach (var b in books)
            {
                Console.WriteLine($"Title : {b.title}");
                Console.WriteLine($"Author : {b.author}");
                Console.WriteLine($"Price : {b.price}");
                Console.WriteLine($"Publisher : {b.publisher}");
            }
        }
    }
}
