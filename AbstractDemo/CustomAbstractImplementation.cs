using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractDemo
{
    public class CustomAbstractImplementation : CustomAbstract
    {
        public override void PrintAbstractMessage()
        {
            Console.WriteLine("C# is fun to program in.");
        }
    }
}
