using System;
using System.Collections.Generic;
using System.Text;

namespace LinqTutorial
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public decimal Salary { get; set; }
        public Department Department { get; set; }

        public static List<Employee> GetEmployees()
        {
            #region List Of All Employees!!!!

            return new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    Name = "Mary Smith",
                    Gender = Gender.Female,
                    Department = new Department()
                    {
                        DepartmentId = 101,
                        DepartmentName = "Finance",
                        Location = "Bardnesville"
                    },
                    Salary = 40000
                },
                new Employee()
                {
                    Id = 2,
                    Name = "John Brown",
                    Gender = Gender.Male,
                    Department = new Department()
                    {
                        DepartmentId = 100,
                        DepartmentName = "IT",
                        Location = "Sinkor 10th Street"
                    },
                    Salary = 500000
                },
                new Employee()
                {
                    Id = 3,
                    Name = "Alicia Collins",
                    Gender = Gender.Female,
                    Department = new Department()
                    {
                        DepartmentId = 100,
                        DepartmentName = "IT",
                        Location = "Sinkor 10th Street"
                    },
                    Salary = 45000
                },
                new Employee()
                {
                    Id = 4,
                    Name = "Prince Jack",
                    Gender = Gender.Male,
                    Department = new Department()
                    {
                        DepartmentId = 100,
                        DepartmentName = "IT",
                        Location = "Sinkor 10th Street"
                    },
                    Salary = 350000
                },
                new Employee()
                {
                    Id = 5,
                    Name = "Beatrice Han",
                    Gender = Gender.Female,
                    Department = new Department()
                    {
                        DepartmentId = 101,
                        DepartmentName = "Finance",
                        Location = "Bardnesville"
                    },
                    Salary = 1000000
                },
                  new Employee()
                {
                    Id = 6,
                    Name = "Jack Brownell",
                    Gender = Gender.Male,
                    Department = new Department()
                    {
                        DepartmentId = 100,
                        DepartmentName = "IT",
                        Location = "Sinkor 10th Street"
                    },
                    Salary = 650000
                }
            };
            #endregion
        }
    }
}
