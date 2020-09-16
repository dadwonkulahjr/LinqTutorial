using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace LinqTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intNumbers = new int[] { 1, 2, 3, 4, 5 };
            var result = Enumerable.Count(intNumbers);
            Console.WriteLine(result);

            Console.ReadLine();
        }

    }


}
