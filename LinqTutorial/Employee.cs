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
        //public string JobTitle { get; set; }
        public Department Department { get; set; }
        public string City { get; set; }
        public decimal Salary { get; set; }
        //public int DepartmentId { get; set; }

        //public override bool Equals(object obj)
        //{
        //    return Name == ((Employee)obj).Name && Id == ((Employee)obj).Id;
        //}

        //public override int GetHashCode()
        //{
        //    return Name.GetHashCode() ^ Id.GetHashCode();
        //}


        //public static IList<Employee> GetEmployees()
        //{
        //    List<Employee> listOfEmployees = new List<Employee>()
        //    {
        //        new Employee()
        //        {
        //            Id = 1,
        //            Gender = Gender.Male,
        //            Name = "Mike Smith",
        //            JobTitle = "Junior Developer",
        //            City = "Sinkor 10th Street",
        //            Salary = 12000,
        //            DepartmentId = 100
                   
        //        },
        //        new Employee()
        //        {
        //            Id = 2,
        //            Gender = Gender.Male,
        //            Name = "Sam Peterson",
        //            JobTitle = "Junior Developer",
        //            City = "Sinkor 10th Street",
        //            Salary = 15000,
        //            DepartmentId = 100
        //        },
        //        new Employee()
        //        {
        //            Id = 3,
        //            Gender = Gender.Male,
        //            Name = "John Brownell",
        //            JobTitle = "Junior Developer",
        //            City = "New Georgia Estate",
        //            Salary = 17000,
        //            DepartmentId = 200
        //        },

        //        new Employee()
        //        {
        //            Id = 4,
        //            Gender = Gender.Female,
        //            Name = "Alicia Collins",
        //            JobTitle = "Junior Developer",
        //            City = "New Georgia Estate",
        //            Salary = 18000,
        //            DepartmentId = 200
        //        },
        //        new Employee()
        //        {
        //            Id = 5,
        //            Gender = Gender.Female,
        //            Name = "Princess",
        //            City = "Monrovia",
        //            Salary = 40000,
        //            DepartmentId = 100
        //        },
        //         new Employee()
        //        {
        //            Id = 6,
        //            Gender = Gender.Male,
        //            Name = "Prince Howell",
        //            City = "Monrovia",
        //            Salary = 50000,
        //            DepartmentId = 200
        //        },
        //        new Employee()
        //        {
        //            Id = 7,
        //            Name = "Mr Wonkulah",
        //            Gender = Gender.Male,
        //            City = "B.ville",
        //            Salary = 450000,
        //            //DepartmentId = 100
        //        },
        //        new Employee()
        //        {
        //            Id = 8,
        //            Name = "Frankie Wok",
        //            Gender = Gender.Male,
        //            City = "B.ville",
        //            Salary = 14000,
        //            //DepartmentId = 100

        //        }
        //    };
        //    return listOfEmployees;
        //}

    }
}
