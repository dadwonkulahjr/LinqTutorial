using System;
using System.Collections.Generic;
using System.Text;

namespace LinqTutorial
{
    public class Mother : Woman
    {
        public Mother(string firstName, string lastName, string gender)
            : base(firstName, lastName, gender)
        {

        }
        public Mother(string firstName, string lastName, string gender, List<string> children, string eyeColor = null)
           : base(firstName, lastName, gender, eyeColor)
        {
            _children = children;
        }
        public Mother(string firstName, string lastName, string gender, string eyeColor)
            : base(firstName, lastName, gender, eyeColor)
        {

        }
        public Mother(List<string> childrenNames)
        {
            _children = childrenNames;
        }
        List<string> _children;
        public override string PrintInfo()
        {
            foreach (string c in _children)
            {
                Console.WriteLine(c);
            }
            return "End of the Loop!".Remove(0, 16);

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }

}

