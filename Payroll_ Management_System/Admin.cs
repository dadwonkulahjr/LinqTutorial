using System;


namespace Payroll__Management_System
{
    public class Admin : Staff
    {
        private const float _overtimeRate = 15.5f;
        private const float _adminHourlyRate = 30;
        public Admin(string name)
            :base(name, _adminHourlyRate)
        {
        }
        public float OverTime { get; private set; }
        public override void CalculatePay()
        {
            base.CalculatePay();
            if(HoursWork < 160)
            {
                TotalPay = HoursWork;
            }
            if(HoursWork > 160)
            {
                OverTime = _overtimeRate * (HoursWork - 160);
            }
        }
        public override string ToString()
        {
            Manager manager = new Manager(null);
            return "Name = " + NameOfStaff + " Basic Pay = " + BasicPay.ToString("c") + "\n" + "Total Pay = " + TotalPay.ToString("c") + "\n" +
               "Overtime = " + OverTime.ToString("c");
        }
    }
}
