using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    public class DoWork : IDoWork
    {
        private int[] _arrayOfNumbers;
        private int _number;

        public DoWork(int[] numbers)
        {
            _arrayOfNumbers = numbers;
        }

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

        public void DisplayNumberValue()
        {
            Console.WriteLine("Number = " + _number);
        }

        //void IDoWork.PrintListOfNames(params string[] names)
        //{
        //    foreach (var item in names)
        //    {
        //        Console.Write(item + " ");
        //    }
        //}
        //int[] IDoWork.PrintArrayValues()
        //{
        //    return _arrayOfNumbers;
        //}
        //void IDoWork.MyList(List<int> numbers)
        //{
        //    int input;
        //    for (int i = 0; i < 3; i++)
        //    {
        //        Console.WriteLine("Enter a number:");
        //        input = Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine("Number has been added to list");
        //        numbers.Add(input);
        //    }
        //    Console.WriteLine();
        //    Console.WriteLine("Display Values:");
        //    Console.WriteLine("------------------------------");
        //    foreach (var item in numbers)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
        public void MyList(List<int> numbers)
        {
            int input;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter a number:");
                input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Number has been added to list");
                numbers.Add(input);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Display Values:");
            Console.WriteLine("------------------------------");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }

        public int[] PrintArrayValues()
        {
            return _arrayOfNumbers;
        }

        public void PrintListOfNames(params string[] names)
        {
            foreach (var item in names)
            {
                Console.Write(item + " ");
            }
        }
    }
}
