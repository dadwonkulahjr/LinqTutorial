using System;
using System.Collections.Generic;

namespace InterfaceDemo
{
    public interface IDoWork
    {
        int[] PrintArrayValues();
        void PrintListOfNames(params string[] names);
        void MyList(List<int> numbers);
        int Number { get; set; }
        void DisplayNumberValue();
     
    }
}
