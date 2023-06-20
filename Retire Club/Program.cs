using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retire_Hub   //DO NOT CHANGE THE NAMESPACE NAME 
{
    public class Program    //DO NOT CHANGE THE CLASS NAME 
    {
        public static void Main(string[] args)      //DO NOT CHANGE THE 'Main'n METHOD SIGNATURE
        {
            //public static Di
            
            //Implement your code here 
            Service service =new Service();
            Console.WriteLine("Enter member id:");
            service.MemberId=Console.ReadLine();
            
            if(service.ValidateMemberId())
            {
                Console.WriteLine("Enter member name:");
                service.MemberName=Console.ReadLine();
                
                Console.WriteLine("Enter member type:");
                // service.MemberType=Console.ReadLine();
                
                double membershipFees=service.CalculateMembershipFees();
                
                Console.WriteLine("Membership Fees is" + membershipFees);
            }
            else{
                Console.WriteLine("Invalid member id:");
            }
        }
    }
}
