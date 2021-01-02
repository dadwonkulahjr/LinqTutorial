using System;
using System.Collections.Generic;
using System.Text;

namespace LinqTutorial
{
    public class Woman : Man
    {
        string _eyeColor;
        protected internal Man _man;
        public Woman(Man man)
            : base(null, null, null)
        {
            _man = man;
        }
        public Woman(string firstName, string lastName, string gender)
            : base(firstName, lastName, gender)
        {

        }
        public Woman(string firstName, string lastName, string gender, string eyeColor)
            : base(firstName, lastName, gender)
        {
            _eyeColor = eyeColor;
        }
        public Woman(string eyeColor = null)
            : base(null, null, null)
        {
            _eyeColor = eyeColor;
        }
        //public override string PrintInfo()
        //{
        //    return string.Format("FirstName = {0}\nLastName = {1}\nGender = {2}\nEyeColor = {3}", _firstName, _lastName, _gender, _eyeColor);
        //}
        public override string ToString()
        {
            return string.Format("FirstName = {0}\nLastName = {1}\nGender = {2}\nEyeColor = {3}", _firstName, _lastName, _gender, _eyeColor);
        }
    }

}
