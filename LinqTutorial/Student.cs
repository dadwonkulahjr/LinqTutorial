using System.Collections.Generic;

namespace LinqTutorial
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public int CourseId { get; set; }

        public static List<Student> GetStudents()
        {
            return new List<Student>()
            {
                new Student(){StudentID = 1, StudentFirstName ="Sara", StudentLastName = "LT City", CourseId = 100 },
                new Student(){StudentID = 2, StudentFirstName ="Sam", StudentLastName = "NG City", CourseId = 100},
                new Student(){StudentID = 3, StudentFirstName ="John", StudentLastName = "Caldwell", CourseId = 200},
                new Student(){StudentID = 4, StudentFirstName ="Rachel", StudentLastName = "Rahab", CourseId = 200},
                new Student(){ StudentID = 5, StudentFirstName ="Caleb", StudentLastName = "USA", CourseId = 300},
                new Student(){ StudentID = 6, StudentFirstName ="Bucky", StudentLastName = "Boston", CourseId = 300}
            };

        }

    }
}
