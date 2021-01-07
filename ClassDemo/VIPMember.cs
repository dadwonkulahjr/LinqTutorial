using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemo
{
    public class VIPMember : Member
    {
        public VIPMember(string name, int pMemberID, int pMemberSince)
            :base(name, pMemberID, pMemberSince)
        {
            Console.WriteLine("Child Constructor with 3 parameters");
            Console.WriteLine("Name = " + name);
        }
        public override void CalculateAnnualFees()
        {
            annualFee = 1200;
        }
    }
}
