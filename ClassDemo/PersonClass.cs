using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemo
{
    public class PersonClass
    {
        public string message = "Hello World!";
        public  static int Age { get; set; }
        public static string greetings { get; set; } = "Good Morning";
        public string Name { get; set; }
        public static void DisplayAge()
        {
            Console.WriteLine($"Age = " + Age);
        }
        public void DisplayName()
        {
            Console.WriteLine($"Name = " + Name);
        }
    }
}
