using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            IOrderedEnumerable<Student> students = Student.GetStudents().OrderBy(s => s.TotalMarks)
                .ThenBy(x => x.Name).ThenBy(x => x.Id);
            foreach (var item in students)
            {
                Console.WriteLine(item.Id + " - " + item.Name + " - " + item.TotalMarks);
            }
            Console.ReadLine();
        }

    }


}
