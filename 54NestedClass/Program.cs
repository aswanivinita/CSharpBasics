using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54NestedClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.SetPersonInfo();
            p.ShowInfo();
        }
    }

    class Person
    {
        private string name;
        private int age;
        private Address address;
        public Person()
        {
            address = new Address();
        }

         class Address
        {
            private string aptNo;
            private string street;
            private string city;
            private string state;
            private string pin;

            public void SetAddress()
            {
                Console.WriteLine("Enter the apartment number");
                aptNo = Console.ReadLine();

                Console.WriteLine("Enter the street");
                street = Console.ReadLine();

                Console.WriteLine("Enter the city");
                city = Console.ReadLine();

                Console.WriteLine("Enter the state");
                state = Console.ReadLine();

                Console.WriteLine("Enter the pincode");
                pin = Console.ReadLine();
            }
            public void ShowAddress()
            {
                Console.WriteLine("Apartment number : " + aptNo);
                Console.WriteLine("Street : " + street);
                Console.WriteLine("City : " + city);
                Console.WriteLine("State : " + state);
                Console.WriteLine("Pincode : " + pin);
            }
        }

        public void SetPersonInfo()
        {
            Console.WriteLine("Enter the name");
            name = Console.ReadLine();

            Console.WriteLine("Enter the age");
            age = int.Parse(Console.ReadLine());

            address.SetAddress();
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age : " + age);
            address.ShowAddress();
        }
    }


}
