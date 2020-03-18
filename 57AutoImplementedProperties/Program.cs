using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57AutoImplementedProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();
            d.Name = "Ram";
            d.Age = 21;
            d.Mobile = 9845098450;
            d.City = "Chennai";

            Console.WriteLine("Name : " + d.Name);
            Console.WriteLine("Age : " + d.Age);
            Console.WriteLine("Mobile : " + d.Mobile);
            Console.WriteLine("City : " + d.City);
        }
    }

    // POCO classes : Plain old CLR object
    // Such classes are used transfer the data from one module another module
    class Demo
    {
        // Auto implemented properties
        public string Name { get; set; }
        public int Age { get; set; }
        public long Mobile { get; set; }
        public string City { get; set; }
    }

}
