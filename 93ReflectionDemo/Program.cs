using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _93ReflectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(Employee);

            PropertyInfo[] pi = t.GetProperties();

            

            foreach(var item in pi)
            {
                Console.WriteLine(item.Name);
            }


            MethodInfo[] mi = t.GetMethods();

            foreach (var item in mi)
            {
                Console.WriteLine(item.Name);
            }
        }
    }

    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public void ShowDetails()
        {

        }

        public void GetDetails()
        {

        }
    }
}
