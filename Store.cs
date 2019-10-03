using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    public class Store
    {
        public Player player;

        Recipe recipe = new Recipe();
        double lemonBagCost;
        double sugarBagCost;
        double iceBagCost;
        double cupsBagCost;
        double userInput;
        double numberOfBags;
        public double lemonBagCount;
        public double sugarBagCount;
        public double iceBagCount;
        public double cupsCount;
        double lemonTotalCost;
        double sugarTotalCost;
        double iceTotalCost;
        double cupTotalCost;
        double wallet;
        public double walletBalance;



        //public Store(Player playerPassIn)
        public Store()
        {
            lemonBagCost = 3.00;
            sugarBagCost = 2.00;
            iceBagCost= 1.00;
            cupsBagCost = 2.00;
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

        }
        public void StoreItemsMenu()
        {
            Console.WriteLine("Welcome to the store.\nYou will buy items here \nLemon Bag = 1\nthe cost is $3.00 and a bag has 30 lemons\nSugar Bag = 2\nthe cost is $2.00 and has 30 servings\nIce Bag = 3\nthe cost is $1.00 and has 300 ice cubes \nCups in a bag = 4\nthe cost is 2.00 and has 100 cups\nIf done enter in 5");
            userInput = double.Parse(Console.ReadLine());                      
            Console.WriteLine("How Many bags?");
            numberOfBags = double.Parse(Console.ReadLine());
            if(wallet <= 0)
            {
                Console.WriteLine("You dont have enough money");
                Console.ReadLine();
            }
            if(userInput == 1)
            {
                userInput = lemonBagCost;
                lemonTotalCost = (lemonBagCost * numberOfBags);
                wallet = (wallet - lemonTotalCost);
                lemonBagCount += numberOfBags;
                Console.WriteLine("You have" + " " + wallet + " " + "left in your wallet");   
                Console.ReadLine();
                StoreItemsMenu();
            }
            if(userInput == 2)
            {
                userInput = sugarBagCost;
                sugarTotalCost = (sugarBagCost * numberOfBags);
                wallet = (wallet - sugarTotalCost);
                sugarBagCount = numberOfBags;
                Console.WriteLine("You have" + " " + wallet + " " + "dollars left in your wallet");
                Console.ReadLine();
                StoreItemsMenu();
            }
            if (userInput == 3)
            {
                userInput = iceBagCost;
                iceTotalCost = (iceBagCost * numberOfBags);
                wallet = (wallet - iceTotalCost);
                iceBagCount = numberOfBags;
                Console.WriteLine("You have" + " " + wallet + " " + "left in your wallet");
                Console.ReadLine();
                StoreItemsMenu();
            }
            if (userInput == 4) 
            {
                userInput = cupsBagCost;
                cupTotalCost = (cupsBagCost * numberOfBags);
                wallet = (wallet - cupTotalCost);
                cupsCount = numberOfBags;
                Console.WriteLine("You have" + " " + wallet + " " + "left in your wallet");
                Console.ReadLine();
                StoreItemsMenu();
            }
            if(userInput == 5)
            {
                recipe.lemonadeBlend();
            }
            else
            {

            }

        }
        public void Banker()
        {
            
          
        }
    }
    
}
