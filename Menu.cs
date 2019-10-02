using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    public static class Menu
    {
        public static string MoneyInWallet;
        
        private static int userInput;

        public static int UserInput { get { return userInput; } set { userInput = value; } }

        private static int numberOfBags;

        public static int NumberOfBags { get { return numberOfBags; } set { numberOfBags = value;  } }
        public static void SetOrder()
        {
            Console.WriteLine("Item List\nLemon Bag is 1 the cost is $3.00 and a bag has 30 lemons\nSugar Bag is 2 the cost is $2.00 and has 30 servings\nIce Bag is 3 the cost is $1.00 and has 300 ice cubes\nPlease input the number for the item");

            userInput = int.Parse(Console.ReadLine());
            Console.WriteLine("How Many bags?");
            numberOfBags = int.Parse(Console.ReadLine());
            
        }
        
        
    }
}
