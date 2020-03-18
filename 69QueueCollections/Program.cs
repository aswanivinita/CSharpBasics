using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _69QueueCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();

            q.Enqueue(123);
            q.Enqueue("Hello");
            q.Enqueue(111.54);

            Console.WriteLine("No of elements are :" +q.Count);

            Console.WriteLine("Last element is :" +q.Peek());

            Console.WriteLine("Removed element is :" +q.Dequeue());

            Console.WriteLine("COunt is: " +q.Count);


        }
    }
}
