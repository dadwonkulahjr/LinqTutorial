using System;
using System.Collections.Generic;
using System.Text;

namespace LinqTutorial
{
    public class Course
    {
        public int ID { get; set; }
        public string ClassName { get; set; }

        public static List<Course> GetCourses()
        {
            return new List<Course>()
            {
                new Course(){ID = 100, ClassName = "BSCS"},
                new Course(){ID = 200, ClassName = "BSSE"},
                new Course(){ID = 300, ClassName = "BSIT"}
            };
        }
    }
}
