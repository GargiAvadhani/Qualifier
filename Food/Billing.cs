using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeOutRestaurant
{
    public class Billing : FoodDetails
    {
        public bool ValidateFoodType(string FoodType)
        {
            if (FoodType == "Samosa" || FoodType == "Spring Roll" || FoodType == "Empanada")
            {
                return true;
            }
            else
            {
                Console.WriteLine("Invalid food type");
                return false;
            }
        }
        public FoodDetails GenerateBill()
        {
            TotalPrice = Quantity*PricePerPiece;
            if(TotalPrice>=100 && TotalPrice<=500)
            Discount = 10;
            else if (TotalPrice>500 && TotalPrice <= 1000)
            Discount=15;
            else if (TotalPrice > 1000)
            Discount=20;
            else 
            Discount=0;
            
            Discount=TotalPrice*Discount/100;
            return this;
        }
    }
}