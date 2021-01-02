using System;
using System.Collections.Generic;
using System.Text;

namespace LinqTutorial
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RandomNumber { get; set; }
        public Gender Gender { get; set; }
        public decimal Salary { get; set; }
        
        public int DepartmentId { get; set; }

     
        public Person(int id, string name, Gender gender, int departmentId=0, decimal salary=0) 
        {
            Id = id;
            Name = name;
            Gender = gender;
            DepartmentId = departmentId;
            Salary = salary;
        }
        
        public override bool Equals(object obj)
        {
            return Id.Equals(((Person)obj).Id) && Name.Equals(((Person)obj).Name) && Gender.Equals(((Person)obj).Gender) && DepartmentId.Equals(((Person)obj).DepartmentId) && Salary.Equals(((Person)obj).Salary);

        }
        public override int GetHashCode()
        {
            return Id.GetHashCode() ^ DepartmentId.GetHashCode() ^ Salary.GetHashCode();
        }
    }
}
