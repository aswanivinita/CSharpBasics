using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _84Linq4
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


            //MULTIPLE WAYS OF ADDING OBJECT TO COLLECTION
            Employee e1 = new Employee();

            e1.Id = 107;
            e1.Name = "Diya";
            e1.City = "Bhopal";
            e1.Mobile = "34546546";

            employees.Add(e1);

            Employee e2 = new Employee() { Id = 108, Name = "Raja", City = "Bhopal", Mobile = "999900877"  };

            employees.Add(e2);


            employees.Add(new Employee() { Id = 109, Name = "Ramesh", City = "Bhopal", Mobile = "999900034"  });


            IEnumerable<Employee> employeeFromBhopal = from emp in employees
                                                       where emp.City == "Bhopal"
                                                       select emp;

            foreach (var emp in employeeFromBhopal)
            {
                Console.WriteLine($"{emp.Id} \t {emp.Name} \t {emp.City} \t {emp.Mobile} \t");
            }


            IEnumerable<Employee> employeeOrderByName = from emp in employees
                                                        orderby emp.Name ascending
             
                                                        select emp;
           
            Console.WriteLine("*****Employee names*****");
            Console.WriteLine("Id \t Name \t city \t mobile \t");

            foreach(var emp in employeeOrderByName)
            {
                Console.WriteLine($"{emp.Id} \t {emp.Name} \t {emp.City} \t {emp.Mobile} \t");
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
