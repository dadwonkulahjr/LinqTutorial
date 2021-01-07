using System;

namespace Payroll_Management_System_2
{
    public class Manager : Staff
    {
        private const float _managerHourlyPayRate = 50;
        public Manager(string name)
            :base(name, _managerHourlyPayRate)
        {

        }
        public int Allowence { get; private set; }
        public override void CalculatePay()
        {
            base.CalculatePay();
            Allowence = 1000;

            if(HoursWorked > 160)
            {
                TotalPay = HoursWorked + Allowence;
            }
        }
        public override string ToString()
        {
            return $"NameOfStaff = {NameOfStaff}\nHoursWorked = {HoursWorked}" +
                $"\nBasicPay = {BasicPay.ToString("c")}\nTotalPay = {TotalPay.ToString("c")}\nHourlyPayRate Manager = {_managerHourlyPayRate.ToString("c")}";
        }
    }
}
