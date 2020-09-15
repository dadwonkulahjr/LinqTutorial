using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = (List<Employee>)Employee.GetEmployees();

            var result = employees.ToLookup(x => x.JobTitle);
            Console.WriteLine("Employees by Job Title:");
            foreach (var kvp in result)
            {
                Console.WriteLine(kvp.Key);
                foreach (var employee in result[kvp.Key])
                {
                    Console.WriteLine("\t" + employee.Name + "\t" + employee.JobTitle + "\t" + employee.City + "\t" + employee.Salary.ToString("c"));
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            var resultSalary = employees.ToLookup(x => x.City, x => x);
            Console.WriteLine("Employee By City:");
            foreach (var kvp in resultSalary)
            {
                Console.WriteLine(kvp.Key);
                foreach (var emp in resultSalary[kvp.Key])
                {
                    Console.WriteLine( "\t" + emp.Name + "\t" + emp.JobTitle + "\t" + emp.City + "\t" + emp.Salary.ToString("c"));
                }
            }
          

            Console.ReadLine();
        }

    }

    

}
