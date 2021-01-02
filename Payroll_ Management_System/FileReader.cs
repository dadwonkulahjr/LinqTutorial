using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Payroll__Management_System
{
    public class FileReader
    {
        public static List<Staff> ReadFile()
        {
        
            string[] result = new string[2];
            string[] seperator = { ","};
            List<Staff> staffs = new List<Staff>();

            if (File.Exists("Staff.txt"))
            {
                using (StreamReader sr = new StreamReader("Staff.txt"))
                {
                    result = sr.ReadLine().Split(seperator, StringSplitOptions.None);

                    if (result[1] == "Manager")
                    {
                        Manager manager = new Manager(result[1]);
                        staffs.Add(manager);
                    }
                    else
                    {
                        Admin admin = new Admin(result[0]);
                        staffs.Add(admin);

                    }
                }
            }
            else
            {
                FileStream fileStream = new FileStream("Staff.txt", FileMode.Open);
                Console.WriteLine($"The file " + fileStream.Name + " does not exists or cannot be found.");
            }
            return staffs.ToList();
        }
    }
}
