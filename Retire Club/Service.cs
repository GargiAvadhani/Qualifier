using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Retire_Hub  //DO NO CHANGE THE NAMESPACE NAME
{
    public class Service : Club //DO NOT change the class name 
    {
        //Implement your code here 
        public bool ValidateMemberId()
        {
            if (MemberId.Length== 8 && MemberId.Substring(0,4)=="meml")
            {
                return true;
            }
            return false;
        }
        public double CalculateMembershipFees()
        {
            if(MemberType=="Gold")
            {
                return 50000;
            }
            else if(MemberType=="Premium")
            {
                return 75000;
            }
            else {
                return 0;
            }
        }
    }
}
