using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _86LinqAnonymoustype
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee{ Id = 101, Name = "Ram", City = "Indore", Mobile = "99990000"},
                new Employee{ Id = 102, Name = "Radha", City = "Bhopal", Mobile = "99990009"},
                new Employee{ Id = 103, Name = "Mohan", City = "Jabalpur", Mobile = "99990656"},
                new Employee{ Id = 104, Name = "Anita", City = "Raipur", Mobile = "99995656"},
                new Employee{ Id = 105, Name = "Rani", City = "Bhopal", Mobile = "9999056767"},
                new Employee{ Id = 106, Name = "Neeta", City = "Indore", Mobile = "999906676"}

            };
            //Creating anonymous type

            Employee e = new Employee() {Id = 107, Name = "Divya", City = "Bhopal", Mobile = "98809090" };

            var x = new { Name = e.Name, City = e.City };

            Console.WriteLine($"Name: {x.Name} \t City: {x.City}");

            //Linq with anonymous type

            var employeesWithNameAndCity = from emp in employees
                                           select new { Name = emp.Name, City = emp.City };

            Console.WriteLine("Name \t City \t");

            foreach (var emp in employeesWithNameAndCity)
            {
                Console.WriteLine($"{emp.Name} \t {emp.City}");
            }


        }
    }

    class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Mobile { get; set; }

        public string City { get; set; }
    }
}
