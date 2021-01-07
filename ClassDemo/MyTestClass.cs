using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemo
{
    public static class MyTestClass
    {
        public static List<int> GetUserData()
        {
            List<int> list = new List<int>();
            int input = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter an integer number:");
                input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Integer added to the list");
                list.Add(input);
            }
            return list;
        }
        public static int[] GetAllData()
        {
            int[] arrayList = new int[3];
            for (int i = 0; i < arrayList.Length; i++)
            {
                Console.WriteLine("Enter an integer number:");
                arrayList[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Item added to the array.");
            }
            return arrayList;
        }
        public static string[] GetAllStringsData()
        {
            string[] arrayOfStr = new string[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter some names:");
                arrayOfStr[i] = Console.ReadLine();
                Console.WriteLine("Name added to array.");
            }
            return arrayOfStr;
        }
        public static void PrintNames(params string[] listOfNames)
        {
            for (int i = 0; i < listOfNames.Length; i++)
            {
                Console.Write(listOfNames[i] + "  ");
            }
        }
        
       

    }
}
