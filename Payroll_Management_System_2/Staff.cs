using System;

namespace Payroll_Management_System_2
{
    public class Staff
    {
        private float _hourlyPayRate;
        private int _hWorked;
        public Staff(string name, float rate)
        {
            NameOfStaff = name;
            _hourlyPayRate = rate;
        }
        public float TotalPay { get; protected set; }
        public float BasicPay { get; private set; }
        public string NameOfStaff { get; private set; }
        public int HoursWorked
        {
            get { return _hWorked; }
            set
            {
                if (value > 0)
                    _hWorked = value;
                else
                    _hWorked = 0;
            }
        }
        public virtual void CalculatePay()
        {
            Console.WriteLine("Calculating Pay...");
            BasicPay = _hWorked * _hourlyPayRate;
            TotalPay = BasicPay;
        }
        public override string ToString()
        {
            return $"NameOfStaff = {NameOfStaff}\nHoursWorked = {_hWorked}" +
                $"\nBasicPay = {BasicPay.ToString("c")}\nTotalPay = {TotalPay.ToString("c")}\nHourlyPayRate = {_hourlyPayRate.ToString("c")}"; 
        }

    }
}
