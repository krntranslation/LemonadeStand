using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    class Store
    {
        public Player player;
        
        double lemonBagCost;
        double sugarBagCost;
        double iceBagCost;
        double userInput;
        double numberOfBags;
        double lemonBagCount;
        double sugarBagCount;
        double iceBagCount;
        double lemonTotalCost;
        double sugarTotalCost;
        double iceTotalCost;
        double wallet;
        double walletBalance;



        public Store()
        {
            lemonBagCost = 3.00;
            sugarBagCost = 2.00;
            iceBagCost= 1.00;
            userInput = 0;
            numberOfBags = 0;
            lemonBagCount = 0;
            sugarBagCount = 0;
            iceBagCount = 0;
            lemonTotalCost = 0.00;
            sugarTotalCost = 0.00;
            iceTotalCost = 0.00;
            wallet = 30.00;
            walletBalance = 0.00;
            
            var cost = new List<double>() {3.00, 2.00, 1.00}; // dont know if i want to use a list for the store or just add put as objects
            var quanity = new List<double>() { 100, 100, 100 };

        }
        public void StoreItemsMenu()
        {
            Console.WriteLine("Welcome to the store.\nYou will buy items here \nLemon Bag is 1 the cost is $3.00 and a bag has 30 lemons\nSugar Bag is 2 the cost is $2.00 and has 30 servings\nIce Bag is 3 the cost is $1.00 and has 300 ice cubes\nIf done enter in 4 \nPlease imput the number for the item and then select the how many bags you want");
            userInput = double.Parse(Console.ReadLine());                       // if user inputs strings it crashes look into it later
            Console.WriteLine("How Many bags?");
            numberOfBags = double.Parse(Console.ReadLine());
           
            if(userInput == 1)
            {
                userInput = lemonBagCost;
                lemonTotalCost = (lemonBagCost * numberOfBags);
                walletBalance = (wallet - lemonTotalCost);
                Console.WriteLine("You have" + " " + walletBalance + " " + "left in your wallet");  // need to have balance of wallet be global 
                Console.ReadLine();
                StoreItemsMenu();
            }
            if(userInput == 2)
            {
                userInput = sugarBagCost;
                sugarTotalCost = (sugarBagCost * numberOfBags);
                walletBalance = (wallet - sugarTotalCost);
                Console.WriteLine("You have" + " " + walletBalance + " " + "dollars left in your wallet");
                Console.ReadLine();
                StoreItemsMenu();
            }
            if (userInput == 3)
            {
                userInput = iceBagCost;
                iceTotalCost = (iceBagCost * numberOfBags);
                walletBalance = (wallet - iceTotalCost);
                Console.WriteLine("You have" + " " + walletBalance + " " + "left in your wallet");
                Console.ReadLine();
                StoreItemsMenu();
            }
            else if (userInput == 4) 
            {
                //goes to recipe
            }
            else
            {
                StoreItemsMenu();      
            }

        }
        public void Banker()
        {
            
          
        }
    }
    
}
