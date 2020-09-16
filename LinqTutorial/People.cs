using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace LinqTutorial
{
    public static class People
    {
        public static string ChangeStringCase(this string stringInput)
        {
            if(stringInput.Length > 0)
            {
                char[] charArray = stringInput.ToCharArray();
                charArray[0] = char.IsUpper(charArray[0]) ? char.ToLower(charArray[0]) : char.ToUpper(charArray[0]);
                return new string(charArray);
            }
            return stringInput;
        }

        public static IList<Person> GetPeople()
        {
            List<Person> people = new List<Person>()
            {
                new Person(id:1, name:"John Brown", gender:Gender.Male, salary:15000, departmentId:100),
                new Person(id:2, name:"Sam Johnson", gender:Gender.Male, salary:20000, departmentId:100),
                new Person(id:3, name:"Mary Brownell", gender:Gender.Female, salary:1500, departmentId:200),
                new Person(id:4, name:"Princss saah", gender:Gender.Female, salary:5000,departmentId:200),
                new Person(id:5, name:"Prince Gabriel", gender:Gender.Male,salary:3500,departmentId:200),
                //new Person(id:6, name:"Patricia Logon", gender:Gender.Female, salary:25000,departmentId:300),
                //new Person(id:7, name:"Alex Tweh", gender:Gender.Male, salary:20000, departmentId:300)
            };
            return people;
        }
    }
}
