using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    class Customer
    {

        private double totalCustomersForWeather;
        private double totalCustomersForRecipe;
        private double percentageOfShopers;
        Weather weather = new Weather();




        public Customer()
        {
            totalCustomersForWeather = 0;
            totalCustomersForRecipe = 0;
            percentageOfShopers = 0;

        }
        public void NumberOfCustomers(int min, int max)
        {

            Random random = new Random();
            totalCustomersForWeather = random.Next(1, 10);
            
        }
        public void NumberOfCustomersForTaste()
        {
            Random random = new Random();
            totalCustomersForRecipe = random.Next(1, 30);

        }
        public void Fifty()
        {
            if(weather.condition == "sunny")
            {
                totalCustomersForWeather = 100;
            }
            if(weather.condition == "raining")
            {
                totalCustomersForWeather = 50;
            }
            if(weather.condition == "cloudy")
            {
                totalCustomersForWeather = 70;
            }
            else
            {

            }
            
        }
        //public void TasteTest()                   // maybe a taste test ask if you have to get taste or just for the weather???
        //{
        //    if(lemons < 3)
        //    {
        //        totalCustomersForRecipe = 50;
        //    }
        //    if(sugar < 3)
        //    {
        //        totalCustomersForRecipe = 40;
        //    }
        //    if(cubes < 3)
        //    {
        //        totalCustomersForRecipe = 30;
        //    }
        //    else
        //    {

        //    }

        //}
        //public void TasteTest1()       // see if you want to change the recipe to a switch case
        //{
        //    int i = 0;
        //    if(i == 0)
        //    {

        //        Console.WriteLine("1 = lemons\n2 = sugar\n3 = icecubes\n4 = cups \n5 = set price\n\nPlease select a option and add items for your recipe for lemonade");
        //        Console.ReadLine();
        //        switch (0)
        //        {
        //            case 1: Console.WriteLine("How many lemons do you want to dd?");
        //                Console.ReadLine();
        //               break;
        //            case 2: Console.WriteLine("How many sugar cubes do you want to add?");
        //                Console.ReadLine();
        //                break;
        //            case 3: Console.WriteLine("How many ice cubes do you want to add?");
        //                Console.ReadLine();
        //            case 4: Console.WriteLine("How much do you want to sell the lemonade for?");
        //                Console.ReadLine();
        //                break;
        //            case 5:Console.WriteLine("Lets go sell some lemonade!");
        //                Console.ReadLine();
        //                break;


        //        }
                
            }
           
        }
        






    }
}
