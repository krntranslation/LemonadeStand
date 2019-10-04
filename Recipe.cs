using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    public class Recipe
    {
        public int addedLemons;
        public int addedSugar;
        public int addedIce;
        public double pricePerCup;
        public double itemSelected;
        public int oneCup;
        //Inventory inventory = new Inventory();
        //Store store = new Store();
        
        public Recipe()
        {
            addedLemons = 0;
            addedSugar = 0;
            addedIce = 0;
            pricePerCup = 0.00;
            itemSelected = 0;
            oneCup = 0;
        }
        public void lemonadeBlend()
        {
            Console.WriteLine("You have " );
            Console.WriteLine("Please combine lemons, sugar, and ice to make your blend of lemonade\nPlease use 1-3 to type in the ammount of each item you want to add\n1 = Lemons\n2 = Sugar\n3 = ice cubes\n4 = Set price per cup");
            itemSelected = int.Parse(Console.ReadLine());
            if (itemSelected == 1)
            {
                Console.WriteLine("You selected lemons, please input the quanity you would like to add");
                addedLemons = int.Parse(Console.ReadLine());
                Console.WriteLine("You added " + addedLemons + " to the lemondade");
                lemonadeBlend();
            }
            if (itemSelected == 2)
            {
                Console.WriteLine("You selected sugar, please input the quanity you would like to add");
                addedSugar = int.Parse(Console.ReadLine());
                Console.WriteLine("You added " + addedSugar + " to the lemondade");
                lemonadeBlend();
            }
            if (itemSelected == 3)
            {
                Console.WriteLine("You selected ice cubes, please input the quanity you would like to add");
                addedIce = int.Parse(Console.ReadLine());
                Console.WriteLine("You added " + addedIce + " to the lemondade");
                lemonadeBlend();
            }
            if (itemSelected == 4)
            {
                Console.WriteLine("Now please set a price, remmeber if the price is too high no one will buy");
                pricePerCup = int.Parse(Console.ReadLine()); 
                Console.WriteLine("Your price is " + pricePerCup);
                lemonadeBlend();
            }
            else
            {

            }
        }
        public void Mix()
        {
            oneCup = (addedLemons + addedSugar + addedIce + addedIce);

            //determine the contents and how they affect the sales for customer, maybe a probabilty generator
        }

            //method for recipe if more/less lemons is added then its too sour, less sales. set a point to where sales are 100% at this 5 and less if less than 5 or greater than 5
            //same for sugar 
            //for ice it depends on the temperature
            //pricepercup should depend on temperature


        
    }
}
