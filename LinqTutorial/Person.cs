using System;
using System.Collections.Generic;
using System.Text;

namespace LinqTutorial
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Gender Gender { get; set; }
        public decimal Salary { get; set; }
        public int DepartmentId { get; set; }

        public Person(int id, string name, Gender gender, int departmentId, decimal salary) 
        {
            Id = id;
            Name = name;
            Gender = gender;
            DepartmentId = departmentId;
            Salary = salary;
        }
    }
}
