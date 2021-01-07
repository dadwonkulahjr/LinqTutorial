using System;

namespace ClassDemo
{
    public class Staff
    {
        private string _nameOfStaff;
        private const int _hourlyPayRate = 30;
        private int _hoursWorked;
        public Staff(string fName, string lName, int hoursWorked)
        {
            _nameOfStaff = fName + ", " + lName;
            _hoursWorked = hoursWorked;
        }
        public Staff(int hoursWorked, string name)
        {
            _hoursWorked = hoursWorked;
            _nameOfStaff = name;

        }
        public Staff(int hoursWorked)
        {
            _hoursWorked = hoursWorked;
        }
        public Staff(string name)
        {
            _nameOfStaff = name;
            Console.WriteLine("\n" + _nameOfStaff);
            Console.WriteLine("---------------------------------");
        }
        public Staff(string fName, string lName)
        {
            _nameOfStaff = fName + ", " + lName;
            Console.WriteLine("\n" + _nameOfStaff);
            Console.WriteLine("---------------------------------");
        }
        public string NameOfStaff
        {
            get { return _nameOfStaff; }
            set
            {
                if (value != null)
                    _nameOfStaff = value;
                else
                    _nameOfStaff = null;
            }
        }
        public int HoursWork
        {
            get { return _hoursWorked; }
            set
            {
                if (value > 0)
                    _hoursWorked = value;
                else
                    _hoursWorked = 0;
            }
        }
        public void PrintMessage()
        {
            Console.WriteLine("Calculating Pay....");
        }
        public int CalculatePay()
        {
            PrintMessage();
            int calculateStaffPay = _hoursWorked * _hourlyPayRate;
            if (_hoursWorked > 0)
                return calculateStaffPay;
            else
                return 0;
        }
        public int CalculatePay(int bonus, int allowence)
        {
            PrintMessage();
            if (_hoursWorked > 0)
                return _hoursWorked * _hourlyPayRate + bonus + allowence;
            else
                return 0;
        }
        public override string ToString()
        {
            return "Name of Staff = " + _nameOfStaff + ", HourlyPayRate = " +
            _hourlyPayRate.ToString("c") + ", HoursWorked = " + _hoursWorked;
        }
    }
}
