using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Payroll__Management_System
{
    public class Payslip
    {
        private int _year;
        private int _month;
        public Payslip(int payYear, int payMonth)
        {
            _year = payYear;
            _month = payMonth;
        }
        public void GeneratePaySlip(List<Staff> listOfStaffObjects)
        {
            string path = string.Empty;
            foreach (Staff myStaff in listOfStaffObjects)
            {
                path = myStaff.NameOfStaff + ".txt";

                using (StreamWriter writeData = new StreamWriter(path))
                {
                    //Manager man = new Manager(path);
                    if (listOfStaffObjects[0].GetType() == typeof(Admin))
                    {
                        writeData.WriteLine("PAYSLIP FOR {0} {1}", (MonthsOfYear)_month, _year);
                        writeData.WriteLine("----------------------------------------------");
                        writeData.WriteLine("----------------------------------------------");
                        writeData.WriteLine("Name of staff: " + myStaff.NameOfStaff);
                        writeData.WriteLine("Hours Work: " + myStaff.HoursWork);
                        writeData.WriteLine("Basic Pay: " + myStaff.BasicPay.ToString("c"));
                        writeData.WriteLine("Overtime: " + ((Admin)myStaff).OverTime.ToString("c"));
                        writeData.WriteLine("Total Pay: " + myStaff.TotalPay.ToString("c"));
                    }
                    else
                    {
                        writeData.WriteLine("PAYSLIP FOR {0} {1}", (MonthsOfYear)_month, _year);
                        writeData.WriteLine("----------------------------------------------");
                        writeData.WriteLine("----------------------------------------------");
                        writeData.WriteLine("Name of staff: " + myStaff.NameOfStaff);
                        writeData.WriteLine("Hours Work: " + myStaff.HoursWork);
                        writeData.WriteLine("Basic Pay: " + myStaff.BasicPay.ToString("c"));
                        writeData.WriteLine("Allowence: " + ((Manager)myStaff).Allowence.ToString("c"));
                        writeData.WriteLine("Total Pay: " + myStaff.TotalPay.ToString("c"));
                    }
                }
            }
        }
        public void GenerateSummary(List<Staff> listOfStaffObjectts)
        {
            var result = (from staff in listOfStaffObjectts
                          where staff.HoursWork < 10
                          select new
                          {
                              NameOfTheStaff = staff.NameOfStaff,
                              EmpHoursWork = staff.HoursWork
                          }).OrderBy(x => x.NameOfTheStaff);

            string path = "Summary.txt";
            using(StreamWriter writer = new StreamWriter(path))
            {
                foreach (var item in result)
                {
                    writer.WriteLine("Staff with less than " + item.EmpHoursWork + " working hours.");
                    writer.WriteLine("Name Of Staff: " + item.NameOfTheStaff);
                }
            }
        }
        public override string ToString()
        {
            return string.Format("Year = " + _year +  " Month = " + _month);
        }
        enum MonthsOfYear
        {
            Jan = 1,
            Feb = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12
        }
    }
}
