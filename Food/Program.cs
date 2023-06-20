using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeOutRestaurant 
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter the food type");
            string FoodType = Console.ReadLine();
            Console.WriteLine("Enter the quantity");
            int Quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the price per piece");
            int PricePerPiece = int.Parse(Console.ReadLine());

            Billing billing = new Billing();
            FoodDetails food = billing.GenerateBill();

            if (food != null)
            {
                Console.WriteLine("Food Type: {0}" , food.FoodType);
                Console.WriteLine("Quantity: {0}", food.Quantity);
                Console.WriteLine("Price Per Price: {0}", food.PricePerPiece);
            }

        }
    }
}