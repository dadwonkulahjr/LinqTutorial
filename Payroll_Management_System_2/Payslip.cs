using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Payroll_Management_System_2
{
    public class Payslip
    {
        private int _year;
        private int _month;
        private StreamWriter _writeData;
        public Payslip(int payYear, int payMonth)
        {
            _month = payMonth;
            _year = payYear;
        }
        enum MonthOfYear
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
        public void GeneratePaySlip(List<Staff> listOfStaffs)
        {
            string path = string.Empty;
            foreach (Staff f in listOfStaffs)
            {
                path = f.NameOfStaff + ".txt";
                if (listOfStaffs[0].GetType() == typeof(Manager))
                {
                    _writeData = new StreamWriter(path);
                    _writeData.WriteLine("PAYSLIP FOR {0} {1}", (MonthOfYear)_month, _year);
                    _writeData.WriteLine("----------------------------------------------");
                    _writeData.WriteLine("----------------------------------------------");
                    _writeData.WriteLine("Name of staff: " + f.NameOfStaff);
                    _writeData.WriteLine("Hours Work: " + f.HoursWorked);
                    _writeData.WriteLine("Basic Pay: " + f.BasicPay.ToString("c"));
                    _writeData.WriteLine("Allowence: " + ((Manager)f).Allowence.ToString("c"));
                    _writeData.WriteLine("----------------------------------------------");
                    _writeData.WriteLine("----------------------------------------------");
                    _writeData.WriteLine("Total Pay: " + f.TotalPay.ToString("c"));
                    _writeData.WriteLine("----------------------------------------------");
                    _writeData.WriteLine("----------------------------------------------");

                }
                else
                {
                    _writeData.WriteLine("PAYSLIP FOR {0} {1}", (MonthOfYear)_month, _year);
                    _writeData.WriteLine("----------------------------------------------");
                    _writeData.WriteLine("----------------------------------------------");
                    _writeData.WriteLine("Name of staff: " + f.NameOfStaff);
                    _writeData.WriteLine("Hours Work: " + f.HoursWorked);
                    _writeData.WriteLine("Basic Pay: " + f.BasicPay.ToString("c"));
                    _writeData.WriteLine("Overtime: " + ((Admin)f).OverTime.ToString("c"));
                    _writeData.WriteLine("----------------------------------------------");
                    _writeData.WriteLine("----------------------------------------------");
                    _writeData.WriteLine("Total Pay: " + f.TotalPay.ToString("c"));
                    _writeData.WriteLine("----------------------------------------------");
                    _writeData.WriteLine("----------------------------------------------");
                }

            }

            _writeData.Close();
        }
        public void GenerateSummary(List<Staff> listOfStaffs)
        {
            var result = (from s in listOfStaffs
                          where s.HoursWorked < 10
                          select new
                          {
                              Name = s.NameOfStaff,
                              HourWorked = s.HoursWorked
                          }).OrderBy(x => x.Name);

            string path = "Summary.txt";
            using (_writeData = new StreamWriter(path))
            {
                foreach (var item in result)
                {
                    _writeData.WriteLine("Staff with less than " + item.HourWorked + " working hours.");
                    _writeData.WriteLine("Name Of Staff: " + item.Name);
                }
            }
        }
        public override string ToString()
        {
            return string.Format("Year = " + _year + " Month = " + _month);
        }
    }
}
