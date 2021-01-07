using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifierDemo
{
    public class ChildClass : ParentClass
    {
        public void PrintDetails()
        {
            Console.WriteLine(_address + " " + _id);
        }
    }
}
