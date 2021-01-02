using System;


namespace Payroll__Management_System
{
    public class Manager : Staff
    {
        private const float _managerHourlyRate = 50;
        public Manager(string name)
            :base(name, _managerHourlyRate)
        {

        }
        public int Allowence { get; private set; }
        public override void CalculatePay()
        {
            base.CalculatePay();
            Allowence = 1000;
            TotalPay = BasicPay;
            if(Allowence == 1000)
            {
                if(HoursWork > 160)
                {
                    TotalPay = HoursWork;
                }
            }
        }
        public override string ToString()
        {
            return "Name = " + NameOfStaff + "Basic Pay = " + BasicPay.ToString("c") + "\n" + "Total Pay = " + TotalPay.ToString("c") + "\n" + 
                "Allowence = " + Allowence.ToString("c");
        }
    }
}
