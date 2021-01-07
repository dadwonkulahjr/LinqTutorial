using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifierDemo
{
    public class GrandChild 
    {
        private ParentClass _parent = new ParentClass();

        public void Print()
        {
            Console.WriteLine(_parent._address);
        }
    }
}
