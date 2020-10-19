using System;
using System.Collections.Generic;
using System.Text;

namespace LinqTutorial
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Courses { get; set; }

        public static List<Student> GetStudents()
        {
            return new List<Student>()
            {
                new Student(){Id = 101,
                    Courses = new
                    List<string>(){"MVC", "Razor", "C#", "DBF" },
                    Name = "Sam"},
                 new Student(){Id = 102,
                    Courses = new
                    List<string>(){"LINQ", "MVC", "Razor", "DBF" },
                    Name = "Mike"},
                  new Student(){Id = 103,
                    Courses = new
                    List<string>(){"C#", "MVC", "Razor", "SRVF"},
                    Name = "Peter"}

            };
        }

    }
}
