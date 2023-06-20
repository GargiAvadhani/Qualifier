using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treasure_Mine
{
    public class Program 
    {
        public static Dictionary <String , int> ProductDetails{get; set;} = new Dictionary <string, int>();

        //Implement Code Here
        public static void AddProductDetails(string itemName, int quantity)
        {
            ProductDetails[itemName] = quantity;
        }
        public static List<string> CheckReorderLevel(int reorderLevel)
        {
            List<string> itemsToReorder = new List<string>();

            foreach (KeyValuePair<string, int> item in ProductDetails)
            {
                if (item.Value < reorderLevel){
                    itemsToReorder.Add(item.Key);
                }
            }
            return itemsToReorder;
        }
        public static void Main(string[] args)
        {
             //Implement Code nHere
             Program program = new Program();

             Console.WriteLine("Enter the number of Products");
             int numberOfProducts = Convert.ToInt32(Console.ReadLine());

             for (int i = 1; i <=numberOfProducts; i++)
             {
                Console.WriteLine("Enter the item name");
                string itemName = Console.ReadLine();

                Console.WriteLine("Enter the stock quantity");
                int stockQunatity = Convert.ToInt32(Console.ReadLine());

                Program.AddProductDetails(itemName, stockQunatity);
             }

             Console.WriteLine("\nEnter re-order level");
             int reorderLevel = Convert.ToInt32(Console.ReadLine());

             List <string> itemsToReorder = Program.CheckReorderLevel(reorderLevel);

             if(itemsToReorder.Count == 0)
             {
                Console.WriteLine("\nNo need for reorder");
             }
             else{
                Console.WriteLine("\nList of Products - reorder level below" + reorderLevel);
                foreach (string item in itemsToReorder)
                {
                    Console.WriteLine(item);
                }
             }
        }
    }
}

