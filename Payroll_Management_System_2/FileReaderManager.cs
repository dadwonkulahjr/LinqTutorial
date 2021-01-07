using System;
using System.Collections.Generic;
using System.IO;

namespace Payroll_Management_System_2
{
    public class FileReaderManager
    {
        private StreamReader _streamReader;
        public FileReaderManager()
        {
            _streamReader = new StreamReader("Staff.txt");
        }
        public List<Staff> ReadFile()
        {
            List<Staff> staffs = new List<Staff>();
            string[] result = new string[2];
            string[] removeSeperator = { "," };

            if (File.Exists("Staff.txt"))
            {
                result = _streamReader.ReadLine().Split(removeSeperator, StringSplitOptions.RemoveEmptyEntries);

                if (result[1].Contains("Manager"))
                {
                    Manager manager = new Manager(result[0]);
                    staffs.Add(manager);
                }
                else if (result[1].Contains("Admin"))
                {
                    Admin admin = new Admin(result[0]);
                    staffs.Add(admin);
                }
            }
            else
            {
                FileStream fileStream = new FileStream("Staff.txt", FileMode.Open, FileAccess.Read);
                Console.WriteLine($"Sorry the file {fileStream.Name} does not exists in the current directory!");
            }

            _streamReader.Close();
            return staffs;
        }
    }
}
