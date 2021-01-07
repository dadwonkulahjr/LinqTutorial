using System;
using System.Collections.Generic;
using System.Text;

namespace StructDemo
{
    public class MyClass
    {
        private int _number;
        public int Number
        {
            get { return _number; }
            set
            {
                if (value > 0)
                    _number = value;
                else
                    _number = 0;
            }
        }
    }

    public enum Days { Sun = 1, Mon = 2, Tuesday = 3 };
}
