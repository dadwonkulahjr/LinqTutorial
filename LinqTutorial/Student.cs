using System;
using System.Collections.Generic;
using System.Text;

namespace LinqTutorial
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TotalMarks { get; set; }
        public Gender Gender { get; set; }

        public static List<Student> GetStudents()
        {
            List<Student> listOfStudents = new List<Student>();
            Student student1 = new Student()
            {
                Id = 1,
                Name = "Mike",
                Gender = Gender.Male,
                TotalMarks = 800
            };
            Student student2 = new Student()
            {
                Id = 2,
                Name = "Mary",
                Gender = Gender.Female,
                TotalMarks = 800
            };
            Student student3 = new Student()
            {
                Id = 3,
                Name = "Samuel",
                Gender = Gender.Male,
                TotalMarks = 600
            };

            Student student4 = new Student()
            {
                Id = 4,
                Name = "Beatrice",
                Gender = Gender.Female,
                TotalMarks = 800
            };
            listOfStudents.Add(student1);
            listOfStudents.Add(student2);
            listOfStudents.Add(student3);
            listOfStudents.Add(student4);
            return listOfStudents;
        }

    }
}
