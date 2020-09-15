using System;
using System.Collections.Generic;
using System.Text;

namespace LinqTutorial
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public Person(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Id = {Id.ToString()}\nName = {Name}\nEmail = {Email}");
        }
    }
}
