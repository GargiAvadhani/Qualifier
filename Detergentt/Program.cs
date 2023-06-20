using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Detergent_Cost
{
    public class Program
    {
        public static void Main(string[] args )
        {
            Service service = new Service();

            Console.WriteLine("Enter bill id");
            service.BillId = Console.ReadLine();

            if (service.ValidateBillId())
            {
                console.WriteLine("Enter detergent name");
                service.Name = Console.ReadLine();

                Console.WriteLine(" Enter pack capacity in grams ");
                service.CostPerPack = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Quantity to Purchase in kgs");
                float quantity =(float)Convert.ToDouble(Console.ReadLine());

                double totalCost =service.CalculateTotalCost(quantity);
                Console.WriteLine("\nDetergent cost is " + totalCost);

            }
            else
            {
                Console.WriteLine("\nInvalid bill id ");
            }
        }
    }
}