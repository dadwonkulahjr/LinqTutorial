using System;
using System.Collections.Generic;
using System.Text;

namespace LinqTutorial
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public int DepartmentId { get; set; }
        public int Salary { get; set; }

        public static List<Employee> GetEmployees()
        {
            //get
            //{
                return new List<Employee>()
                {
                    new Employee(){EmployeeId = 1, Name = "Mike", Gender = Gender.Male, DepartmentId = 100, Salary = 25000},
                    new Employee(){EmployeeId = 2, Name = "Mary", Gender = Gender.Female, DepartmentId = 100, Salary = 10000},
                    new Employee(){EmployeeId = 3, Name = "James", Gender = Gender.Male, DepartmentId = 200, Salary = 5000},
                    new Employee(){EmployeeId = 4, Name = "Cath", Gender = Gender.Female, DepartmentId = 200, Salary = 65000},
                    new Employee(){EmployeeId = 5, Name = "Paul", Gender = Gender.Male, DepartmentId = 100, Salary = 16000},
                    new Employee(){EmployeeId = 6, Name = "Rose", Gender = Gender.Female, DepartmentId = 200, Salary = 14000},
                    new Employee(){EmployeeId = 7, Name = "Sam", Gender = Gender.Male, DepartmentId = 100, Salary = 170000},
                    new Employee(){EmployeeId = 8, Name = "Bendu", Gender = Gender.Female, DepartmentId =200, Salary = 200000},
                    new Employee(){EmployeeId = 9, Name = "Alex", Gender = Gender.Male, DepartmentId = 100, Salary = 220000},
                    new Employee(){EmployeeId = 10, Name = "Sara", Gender = Gender.Female, Salary = 8000}
                };
            //}

        }
    }
}
