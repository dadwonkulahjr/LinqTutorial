using System;
using System.Collections.Generic;
using System.Text;

namespace LinqTutorial
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public string City { get; set; }
        public decimal Salary { get; set; }

        public static IList<Employee> GetEmployees()
        {
            List<Employee> listOfEmployees = new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    Name = "Mike Smith",
                    JobTitle = "Junior Developer",
                    City = "Sinkor 10th Street",
                    Salary = 12000
                },
                new Employee()
                {
                    Id = 2,
                    Name = "Sam Peterson",
                    JobTitle = "Junior Developer",
                    City = "Sinkor 10th Street",
                    Salary = 15000
                },
                new Employee()
                {
                    Id = 3,
                    Name = "John Brownell",
                    JobTitle = "Junior Developer",
                    City = "New Georgia Estate",
                    Salary = 17000
                },

                new Employee()
                {
                    Id = 4,
                    Name = "Alicia Collins",
                    JobTitle = "Junior Developer",
                    City = "New Georgia Estate",
                    Salary = 18000
                },
                new Employee()
                {
                    Id = 5,
                    Name = "Princess Generous",
                    JobTitle = "Senior Developer",
                    City = "Monrovia",
                    Salary = 40000
                },
                 new Employee()
                {
                    Id = 6,
                    Name = "Prince Howell",
                    JobTitle = "Senior Developer",
                    City = "Monrovia",
                    Salary = 50000
                },
                  new Employee()
                {
                    Id = 7,
                    Name = "Dad S Wonkulah Jr",
                    JobTitle = "Senior Developer",
                    City = "B.ville",
                    Salary = 450000
                },
            };
            return listOfEmployees;
        }

    }
}
