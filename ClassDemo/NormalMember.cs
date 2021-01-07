using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemo
{
    public class NormalMember : Member
    {
        public NormalMember(string remarks, string pName, int pMemberId, int pMemberSince)
           : base(pName, pMemberId, pMemberSince)
        {
            Console.WriteLine("Child Constructor with 4 parameters");
            Console.WriteLine("Remarks: " + remarks);
        }

        public override void CalculateAnnualFees()
        {
            annualFee = 100 + 12 * 30;
        }
    }
}
