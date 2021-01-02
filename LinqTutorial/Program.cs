using Payroll__Management_System;
using System;
using System.Collections.Generic;

namespace LinqTutorial
{
    //public enum Occupation
    //{
    //    HR = 10,
    //    Programmer = 88,
    //    Developer = 100,
    //    Payroll = 5,
    //    Manager = 1000,
    //    Junior_Dev = 1,
    //    Senior_Dev = 11,
    //    Finance = 33

    //}
    //public class SomeLinqDepartment
    //{
    //    public int ID { get; set; }
    //    public string Name { get; set; }

    //    public static List<SomeLinqDepartment> GetDept()
    //    {
    //        return new List<SomeLinqDepartment>()
    //        {
    //            new SomeLinqDepartment() {ID = 1, Name = "IT"},
    //            new SomeLinqDepartment() {ID = 2, Name = "HR"},
    //            new SomeLinqDepartment() {ID = 3, Name = "Payroll"},
    //            new SomeLinqDepartment() {ID = 4, Name = "Accountant"},
    //            new SomeLinqDepartment() {ID = 5, Name = "Admin"},
    //        };
    //    }
    //}
    //public class SomeLinqQuery
    //{
    //    public int ID { get; set; }
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public Gender Gender { get; set; }
    //    public decimal Salary { get; set; }
    //    public Occupation Occupation { get; set; }
    //    public int DepartmentId { get; set; }

    //    public static List<SomeLinqQuery> GetEmployeeList()
    //    {
    //        //return null;
    //        return new List<SomeLinqQuery>()
    //        {
    //            new SomeLinqQuery(){ID = 1, FirstName = "Mike", LastName = "Smith", Gender = Gender.Male, Salary = 5000, Occupation = Occupation.HR, DepartmentId = 2},
    //            new SomeLinqQuery(){ID = 2, FirstName = "Sara", LastName = "Peters", Gender = Gender.Female, Salary = 2000, Occupation = Occupation.HR, DepartmentId = 2},
    //            new SomeLinqQuery(){ID = 3, FirstName = "Prince", LastName = "Collins", Gender = Gender.Male, Salary = 3500, Occupation = Occupation.Junior_Dev, DepartmentId = 1},
    //            new SomeLinqQuery(){ID = 4, FirstName = "Rose", LastName = "Kerkula", Gender = Gender.Female, Salary = 1500, Occupation = Occupation.Junior_Dev, DepartmentId = 1},
    //            new SomeLinqQuery(){ID = 5, FirstName = "Sam", LastName = "Toe", Gender = Gender.Male, Salary = 2500, Occupation = Occupation.Programmer, DepartmentId = 1},
    //            new SomeLinqQuery(){ID = 6, FirstName = "Tracy", LastName = "Will", Gender = Gender.Female, Salary = 1000, Occupation = Occupation.Programmer, DepartmentId = 1},
    //            new SomeLinqQuery(){ID = 7, FirstName = "Leo", LastName = "Frank", Gender = Gender.Male, Salary = 800, Occupation = Occupation.Finance, DepartmentId = 4},
    //            new SomeLinqQuery(){ID = 8, FirstName = "Jessica", LastName = "Jonnel", Gender = Gender.Female, Salary = 4000, Occupation = Occupation.Finance, DepartmentId = 4},
    //            new SomeLinqQuery(){ID = 9, FirstName = "Paul", LastName = "Kollie", Gender = Gender.Male, Salary = 6000, Occupation = Occupation.Senior_Dev, DepartmentId = 1},
    //            new SomeLinqQuery(){ID = 10, FirstName = "Rita", LastName = "Brown", Gender = Gender.Female, Salary = 500, Occupation= Occupation.Payroll, DepartmentId = 3},
    //            new SomeLinqQuery(){ID = 11, FirstName = "Alex", LastName = "Payne", Gender = Gender.Male, Salary = 8000, Occupation = Occupation.Manager, DepartmentId = 5},
    //            new SomeLinqQuery(){ID = 12, FirstName = "Louise", LastName = "Doe", Gender = Gender.Female, Salary = 750, Occupation = Occupation.Payroll, DepartmentId = 3}
    //        };
    //    }
    //}
    //public class Staff
    //{
    //    private string _nameofStaff;
    //    private const int _hourlyPayRate = 30;
    //    private int _hoursWork;
    //    public Staff(string name)
    //    {
    //        _nameofStaff = name;
    //        Console.WriteLine("\n" + _nameofStaff);
    //        Console.WriteLine("--------------------------------------");
    //    }
    //    public Staff(string firstName, string lastName)
    //    {
    //        _nameofStaff = firstName + ", " + lastName;
    //        Console.WriteLine("\n" + _nameofStaff);
    //        Console.WriteLine("--------------------------------------");
    //    }
    //    public string StaffName
    //    {
    //        get
    //        {
    //            if (_nameofStaff != null || _nameofStaff != "")
    //            {
    //                return _nameofStaff;
    //            }
    //            else { throw new ArgumentNullException("StaffName", "Property cannot be null or empty."); }
    //        }
    //    }
    //    public int HoursWork
    //    {
    //        get { return _hoursWork; }
    //        set
    //        {
    //            if (value > 0)
    //                _hoursWork = value;
    //            else
    //                _hoursWork = 0;
    //        }
    //    }
    //    private void PrintMessage()
    //    {
    //        Console.WriteLine("Calculating pay...");
    //    }
    //    public int CalculateStaffPay()
    //    {
    //        PrintMessage();
    //        int calculateStaffPay = _hoursWork * _hourlyPayRate;
    //        if (_hoursWork > 0)
    //            return calculateStaffPay;
    //        else
    //            return 0;
    //    }
    //    public int CalculateStaffPay(int allowance, int bonus)
    //    {
    //        PrintMessage();
    //        if (_hoursWork > 0)
    //            return _hoursWork * _hourlyPayRate + allowance + bonus;
    //        else
    //            return 0;
    //    }
    //    public override string ToString()
    //    {
    //        return "Name of Staff = " + _nameofStaff + ", Hourly Pay Rate = " +
    //        _hourlyPayRate.ToString("c") + ", Hours Work = " + _hoursWork;
    //    }
    //}


    public class Program
    {

        static void Main(string[] args)
        {
           
            Console.ReadLine();
        }
    }


}











