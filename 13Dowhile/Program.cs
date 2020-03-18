using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13Dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice; int totalAmount = 0;

            do
            {
                Console.WriteLine("\t *****Fruit Stall*****");
                Console.WriteLine("\t 1. Apples  \t 100Rs");
                Console.WriteLine("\t 2. Oranges \t 50Rs");
                Console.WriteLine("\t 3. Banana \t 20Rs");
                Console.WriteLine("\t 4. Exit");



                Console.WriteLine("Please enter your choice");
                choice = int.Parse(Console.ReadLine());


            if (choice == 1)
            {
                Console.WriteLine("Enter the quantity");
                int qty = int.Parse(Console.ReadLine());

                 totalAmount += 100 * qty;
            }


            if (choice == 2)
                {
                    Console.WriteLine("Enter the quantity");
                    int qty = int.Parse(Console.ReadLine());

                    totalAmount += (50 *qty);

                }

            if (choice == 3)
                {
                    Console.WriteLine("Enter the quantity");
                    int qty = int.Parse(Console.ReadLine());

                     totalAmount += 20 * qty;
                }





            } while (choice != 4);
            Console.WriteLine(totalAmount);



        }
    }
}
