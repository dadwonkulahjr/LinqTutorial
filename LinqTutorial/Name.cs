using System;
using System.Collections.Generic;
using System.Text;

namespace LinqTutorial
{
    public struct Name
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int MagicNumber { get; }
        public Name(string firstName, string middleName, string lastName, int magicNumber)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            MagicNumber = magicNumber;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", FirstName, MiddleName, LastName);
        }

        public string Initials()
        {
            return string.Format("{0} {1} {2}", FirstName.Substring(0, 1), MiddleName.Substring(0, 1), LastName.Substring(0, 1));
        }

        public void DisplayAllData()
        {
            if (MagicNumber % 2 == 0)
            {
                Console.WriteLine($"{MagicNumber} is an Even number!");
            }
            else
            {
                Console.WriteLine($"{MagicNumber} is an Odd number!");
            }
        }
    }
}
