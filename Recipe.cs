using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    public class Recipe
    {
        public double addedLemons;
        public double addedSugar;
        public double addedIce;
        public double pricePerCup;
      
        
        public Recipe()
        {
            addedLemons = 0;
            addedSugar = 0;
            addedIce = 0;
            pricePerCup = 0.00;
        }
        public void lemonadeBlend()
        {
            Console.WriteLine("Please combine lemon, sugar, and ice to make your blend of lemonade");
            Console.ReadLine();


            //method for recipe if more/less lemons is added then its too sour, less sales. set a point to where sales are 100% at this 5 and less if less than 5 or greater than 5
            //same for sugar 
            //for ice it depends on the temperature
            // pricepercup should depend on temperature
            
            
        }
    }
}
