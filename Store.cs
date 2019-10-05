﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    public class Store
    {
        public Player player;
        //public Wallet wallet;
        //Wallet wallet = new Wallet();
        //public Inventory inventory;commented out for testing
        //Recipe recipe = new Recipe(); comment out for testing
        public double lemonBagCost;
        public double sugarBagCost;
        public double iceBagCost;
        public double cupsBagCost;
        public double userInput;
        public double numberOfBags;
        public double lemonBagCount;
        public double sugarBagCount;
        public double iceBagCount;
        public double cupsCount;
        public double lemonTotalCost;
        public double sugarTotalCost;
        public double iceTotalCost;
        public double cupTotalCost;
        public double wallet;
        public double walletBalance;
        
        public int runNotRun; // may not need this

        
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
            runNotRun = 0;
            wallet = 30.00;
            walletBalance = 0.00;

        }
        public void StoreItemsMenu()
        {
            Console.WriteLine("Welcome to the store.\nYou will buy items here \nLemon Bag = 1\nthe cost is $3.00 and a bag has 30 lemons\nSugar Bag = 2\nthe cost is $2.00 and has 30 servings\nIce Bag = 3\nthe cost is $1.00 and has 300 ice cubes \nCups in a bag = 4\nthe cost is 2.00 and has 300 cups\nto check what you purchased = 5\nIf done enter 6");
            userInput = double.Parse(Console.ReadLine());                      

            if(wallet <= 0.00)
            {
                Console.WriteLine("You dont have enough money");
                Console.ReadLine();
            }
            if(userInput == 1)
            {
                Console.WriteLine("How Many bags?");
                numberOfBags = double.Parse(Console.ReadLine());
                userInput = lemonBagCost;
                lemonTotalCost = (lemonBagCost * numberOfBags);
                walletBalance = (wallet - lemonTotalCost);
                lemonBagCount = numberOfBags;
                ///*player.inventory.amountOfLemons = */lemonBagCount;
                Console.WriteLine("You have" + " " + walletBalance + " " + "left in your wallet");   
                Console.ReadLine();
                StoreItemsMenu();
            }
            if(userInput == 2)
            {
                Console.WriteLine("How Many bags?");
                numberOfBags = double.Parse(Console.ReadLine());
                userInput = sugarBagCost;
                sugarTotalCost = (sugarBagCost * numberOfBags);
                walletBalance = (wallet - sugarTotalCost);
                sugarBagCount = numberOfBags;
                Console.WriteLine("You have" + " " + walletBalance + " " + "dollars left in your wallet");
                Console.ReadLine();
                StoreItemsMenu();
            }
            if (userInput == 3)
            {
                Console.WriteLine("How Many bags?");
                numberOfBags = double.Parse(Console.ReadLine());
                userInput = iceBagCost;
                iceTotalCost = (iceBagCost * numberOfBags);
                walletBalance = (wallet - iceTotalCost);
                iceBagCount = numberOfBags;
                Console.WriteLine("You have" + " " + walletBalance + " " + "left in your wallet");
                Console.ReadLine();
                StoreItemsMenu();
            }
            if (userInput == 4) 
            {
                Console.WriteLine("How Many bags?");
                numberOfBags = double.Parse(Console.ReadLine());
                userInput = cupsBagCost;
                cupTotalCost = (cupsBagCost * numberOfBags);
                walletBalance = (wallet - cupTotalCost);
                cupsCount = numberOfBags;
                Console.WriteLine("You have" + " " + walletBalance + " " + "left in your wallet");
                Console.ReadLine();
                StoreItemsMenu();
            }
            if(userInput == 5)
            {
                Console.WriteLine("This is what you purchased,\nyou have " + lemonBagCount + " lemons\nyou have " + sugarBagCount + " sugar\nyou have " + iceBagCount + " ice bags\nand you have " + cupsCount + " cups\nenter 1 to continue shopping or 2 to leave store");
                runNotRun = int.Parse(Console.ReadLine());
                if(runNotRun == 1)
                {
                    StoreItemsMenu();
                }
                if(runNotRun == 2)
                {
                    //recipe.lemonadeBlend();
                }
            }
            if (userInput == 6)
            {
                player.inventory.MultiplyingLemons();
                //inventory.MultiplyingLemons();
            }

            else
            {

            }

        }
        //public void ItemsPurchased()
        //{
        //}
        //public void Banker()
        //{
            
          
        //}
    }
    
}
