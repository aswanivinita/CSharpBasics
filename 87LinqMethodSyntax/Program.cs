using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _87LinqMethodSyntax
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


            IEnumerable<Employee> allEmployees = employees.ToList();

            Console.WriteLine("All Employees");
            Console.WriteLine("Id \t Name \t City \t Mobile ");

            foreach (var emp in allEmployees)
            {
                Console.WriteLine($"{emp.Id} \t {emp.Name} \t {emp.City} \t {emp.Mobile}");
            }



            IEnumerable<Employee> employeesFromBhopal = employees.Where(emp => emp.City == "Bhopal").ToList();

            Console.WriteLine("All Employees from Bhopal");
            Console.WriteLine("Id \t Name \t City \t Mobile ");

            foreach (var emp in employeesFromBhopal)
            {
                Console.WriteLine($"{emp.Id} \t {emp.Name} \t {emp.City} \t {emp.Mobile}");
            }


            IEnumerable<Employee> employeesFromBhopalAndJabalpur = employees.Where(emp => emp.City == "Bhopal"|| emp.City == "Jabalpur").ToList();

            Console.WriteLine("All Employees from Bhopal or Jabalpur");
            Console.WriteLine("Id \t Name \t City \t Mobile ");

            foreach (var emp in employeesFromBhopalAndJabalpur)
            {
                Console.WriteLine($"{emp.Id} \t {emp.Name} \t {emp.City} \t {emp.Mobile}");
            }


            IEnumerable<Employee> employeesOrderByName = employees.OrderBy(emp => emp.Name).ToList();

            Console.WriteLine("All Employees order by name");
            Console.WriteLine("Id \t Name \t City \t Mobile ");

            foreach (var emp in employeesOrderByName)
            {
                Console.WriteLine($"{emp.Id} \t {emp.Name} \t {emp.City} \t {emp.Mobile}");
            }


            //var employeesGroupByCity = from emp in employees
            //                           group emp by emp.City;

            var employeesGroupByCity = employees.GroupBy(emp => emp.City);

            foreach (var group in employeesGroupByCity)
            {
                Console.WriteLine("Grouped by city:" + group.Key);

                foreach (var emp in group)
                {
                    Console.WriteLine($"\t {emp.Id} \t {emp.Name} \t {emp.City} \t {emp.Mobile}");
                }
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
