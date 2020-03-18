using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _68StackCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            stack.Push(1);
            stack.Push("Hello");
            stack.Push(123.43);

            Console.WriteLine("No of elements are:" +stack.Count);

            Console.WriteLine("Element at top is:" + stack.Peek());

            Console.WriteLine("Removed element is :" +stack.Pop());

            Console.WriteLine("No of elements are:" + stack.Count);

            object[] array = stack.ToArray();

            foreach(object item in array)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("FIrst element in array is:" +array[0] );

            Console.WriteLine(stack.Contains("Hello"));
            Console.WriteLine(stack.Contains("Hi"));
        }
    }


}
