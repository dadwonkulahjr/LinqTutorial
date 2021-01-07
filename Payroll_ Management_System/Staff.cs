using System;

namespace Payroll__Management_System
{
    public class Staff
    {
        private float _hourlyRate;
        private int _hoursWork;
        private string _nameOfStaff;
        private float _basicPay;
        private float _totalPay;
        public virtual void CalculatePay()
        {
            Console.WriteLine("Calculating Pay...");
            _basicPay = _hoursWork * _hourlyRate;
            _totalPay = _basicPay;
        }
        public override string ToString()
        {
            return "Name = " + _nameOfStaff + "Basic Pay = " + _basicPay.ToString("c") + "\n" + "Total Pay = " + _totalPay.ToString("c");
        }
        public Staff(string name, float rate)
        {
            _nameOfStaff = name;
            _hourlyRate = rate;
        }
        public int HoursWork
        {
            get { return _hoursWork; }
            set
            {
                if (value > 0)
                {
                    _hoursWork = value;
                }
                else
                {
                    _hoursWork = 0;
                }
            }
        }
        public float TotalPay
        {
            get
            {
                return _totalPay;
            }
            protected
                set
            {
                if (value > 0)
                    _totalPay = value;
                else
                    _totalPay = 0;
            }
        }
        public float BasicPay
        {
            get
            {
                return _basicPay;
            }
            private set
            {
                if (value > 0)
                    _basicPay = value;
                else
                    _basicPay = 0;
            }
        }
        public string NameOfStaff
        {
            private set
            {
                _nameOfStaff = value;
            }
            get
            {
                if (_nameOfStaff != null && _nameOfStaff != "")
                {
                    return _nameOfStaff;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}

        //Code to run the Program in the Method....
//        List<Staff> listOfStaffObjects = new List<Staff>();
//        int month = 0; int year = 0;
//            while (year == 0)
//            {
//                try
//                {
//                    Console.Write("Please enter the year: ");
//                    year = Convert.ToInt32(Console.ReadLine());

//                    while (month == 0)
//                    {
//                        try
//                        {
//                            Console.Write("Please enter the month: ");
//                            month = Convert.ToInt32(Console.ReadLine());

//                            if (month< 1 || month> 12)
//                            {
//                                Console.WriteLine("Invalid month entered.");
//                                month = 0;
//                            }
//                            else
//                            {
//                                listOfStaffObjects = FileReader.ReadFile();
//                                for (int i = 0; i<listOfStaffObjects.Count; i++)
//                                {
//                                    try
//                                    {
//                                        Console.WriteLine("Enter the hours work for " + listOfStaffObjects[i].NameOfStaff + ": ");
//                                        listOfStaffObjects[i].HoursWork = Convert.ToInt32(Console.ReadLine());

//                                        listOfStaffObjects[i].CalculatePay();
//    Console.WriteLine(listOfStaffObjects[i].ToString());

//                                        Payslip ps = new Payslip(year, month);
//    ps.GeneratePaySlip(listOfStaffObjects);
//                                        ps.GenerateSummary(listOfStaffObjects);
//                                        Console.Read();
//                                    }
//                                    catch (Exception ex)
//{
//    i--;
//    Console.WriteLine(ex.Message);
//}
//                                }
//                            }
//                        }
//                        catch (Exception ex)
//{

//    Console.WriteLine(ex.Message);
//}

//                    }
//                }
//                catch (FormatException ex)
//{

//    Console.WriteLine(ex.Message);
//}
//            }


//    }
//}
