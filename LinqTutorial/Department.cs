using System;
using System.Collections.Generic;
using System.Text;

namespace LinqTutorial
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
       
        public static List<Department> GetDepartments()
        {
            return new List<Department>()
           {
               new Department()
               {
                   DepartmentId = 100,
                   DepartmentName = "IT"
               },
                new Department()
               {
                   DepartmentId = 200,
                   DepartmentName = "HR"
               },
                 new Department()
               {
                   DepartmentId = 300,
                   DepartmentName = "Payroll"
               },
           };
        }


    }
}
