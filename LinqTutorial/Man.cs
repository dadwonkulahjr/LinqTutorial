using System;
using System.Collections.Generic;
using System.Text;

namespace LinqTutorial
{
    public class Man
    {
        protected string _firstName;
        protected string _lastName;
        protected string _gender;
        public Man(string firstName, string lastName, string gender)
        {
            _firstName = firstName;
            _lastName = lastName;
            _gender = gender;
        }
        public override string ToString()
        {
            return string.Format("FirstName = {0}\nLastName = {1}\nGender = {2}", _firstName, _lastName, _gender);
        }
        public virtual string PrintInfo()
        {
            return string.Format("FirstName = {0}\nLastName = {1}\nGender = {2}", _firstName, _lastName, _gender);
        }
    }
}
