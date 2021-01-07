using System;


namespace Payroll_Management_System_2
{
    public class Admin : Staff
    {
        private const float _overTimeRate = 15.5f;
        private const float _adminHourlyPayRate = 30;
        public Admin(string name)
            :base(name, _adminHourlyPayRate)
        {

        }
        public float OverTime { get; private set; }
        public override void CalculatePay()
        {
            base.CalculatePay();
            if(HoursWorked > 160)
            {
                OverTime = _overTimeRate * (HoursWorked - 160);
                TotalPay = OverTime;
            }
        }
        public override string ToString()
        {
            return $"NameOfStaff = {NameOfStaff}\nHoursWorked = {HoursWorked}" +
                $"\nBasicPay = {BasicPay.ToString("c")}\nTotalPay = {TotalPay.ToString("c")}\nHourlyPayRate Admin = {_adminHourlyPayRate.ToString("c")}";
        }
    }
}
