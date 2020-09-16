using System;
using System.Collections.Generic;
using System.Text;

namespace LinqTutorial
{
    public class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
       
        public static IList<Department> GetDepartments()
        {
            return new List<Department>()
           {
               new Department()
               {
                   Id = 100,
                   DepartmentName = "IT"
               },
                new Department()
               {
                   Id = 200,
                   DepartmentName = "HR"
               },
                 new Department()
               {
                   Id = 300,
                   DepartmentName = "Payroll"
               },
           };
        }


    }
}
