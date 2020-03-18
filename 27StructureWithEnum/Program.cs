using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27StructureWithEnum
{
    enum Category
    {
        Fiction,
        Comedy,
        Scientic,
        Biography
    }
    struct Book
    {
        public string title;
        public string author;
        public int price;
        public string publisher;
        public Category category;
    }

    struct User
    {
        public string name;
        public string city;
        public Book book;
    }
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.name = "Ram";
            user.city = "Goa";
            user.book = new Book() { title = "ANSI C", author = "Balaguru samy", price = 200, publisher = "Mc Grah Hill", category = Category.Scientic };

            Console.WriteLine($"User Name : {user.name}");
            Console.WriteLine($"City : {user.city}");
            Console.WriteLine($"Title : {user.book.title}");
            Console.WriteLine($"Author : {user.book.author}");
            Console.WriteLine($"Price : {user.book.price}");
            Console.WriteLine($"Publisher : {user.book.publisher}");
            Console.WriteLine($"Category : {user.book.category}");
        }
    }
}
