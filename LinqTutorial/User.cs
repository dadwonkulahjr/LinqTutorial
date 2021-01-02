using System;

namespace LinqTutorial
{

    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string FullName
        {
            get
            {
                return string.Format($"FirstName = {FirstName}\n" +
            $"LastName = {LastName}\nEmail = {Email}\nUserId = {UserId.ToString()}");
            }
        }
        public string PrintUser(int times)
        {
            string message = null;
            for (int i = 0; i < times; i++)
            {
                message += FirstName + ", " + LastName + " - " + i.ToString() + "\n";
            }

            return message;
        }

        public string PrintUser(string firstName, string lastName)
        {
            return firstName + ", " + lastName;
        }

        public string PrintUser(string name, int age)
        {
            return string.Format($"Name = {name}\nAge = {age}");
        }

        public string PrintUser(User user)
        {
            return user.LastName + ", " + user.FirstName;
        }

        public string PrintUser(User user, decimal salary, DateTime birthdate, Gender gender)
        {
            return string.Format($"User details\n{user.FullName}\nSalary = {salary.ToString("c")}" +
                $"\nBirthdate = {birthdate.ToShortDateString()}\nGender = {gender}");
        }
    }
}
