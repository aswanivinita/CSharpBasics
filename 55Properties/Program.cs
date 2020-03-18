using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            //p.SetName("Ram");
            //Console.WriteLine(p.GetName());
            Console.WriteLine("Enter the name");
            p.Name = Console.ReadLine();
            Console.WriteLine("Your name is " + p.Name);
        }
    }

    class Person
    {
        private string name;

        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        //public void SetName(string n)
        //{
        //    name = n;
        //}

        //public string GetName()
        //{
        //    return name;
        //}
    }

}
