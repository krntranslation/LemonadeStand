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
        private double totalCustomersForPrice;
        Weather weather = new Weather();
        Recipe recipe = new Recipe();




        public Customer()
        {
            totalCustomersForWeather = 0;
            totalCustomersForRecipe = 0;
            totalCustomersForPrice = 0;
            percentageOfShopers = 0;


        }
        public void NumberOfCustomers()
        {
            if (weather.condition == "sunny" && weather.temperature >= 88)
            {
                totalCustomersForWeather = 100;
            }
            if (weather.condition == "sunny" && weather.temperature < 88 && weather.temperature >= 70)
            {
                totalCustomersForWeather = 80;
            }
            if (weather.condition == "sunny" && weather.temperature < 70 && weather.temperature >= 65)
            {
                totalCustomersForWeather = 70;
            }
            if (weather.condition == "cloudy" && weather.temperature >= 88)
            {
                totalCustomersForWeather = 80;
            }
            if (weather.condition == "cloudy" && weather.temperature < 88 && weather.temperature >= 70)
            {
                totalCustomersForWeather = 70;
            }
            if (weather.condition == "cloudy" && weather.temperature < 70 && weather.temperature >= 65)
            {
                totalCustomersForWeather = 60;
            }
            if (weather.condition == "raining" && weather.temperature >= 88)
            {
                totalCustomersForWeather = 70;
            }
            if (weather.condition == "raining" && weather.temperature < 88 && weather.temperature >= 70)
            {
                totalCustomersForWeather = 60;
            }
            if (weather.condition == "raining" && weather.temperature <= 70)
            {
                totalCustomersForWeather = 50;
            }
            else
            {

            }


        }

        public void NumberOfCustomersForPrice(int min, int max)
        {
            if (recipe.pricePerCup >= 0.00)
            {
                Random random = new Random();
                totalCustomersForPrice = random.Next(50, 101); // ammount of customers to buy try this see if it works
                Console.WriteLine("You sold " + totalCustomersForPrice + " cups of lemonade.");
                Console.ReadLine();

            }
            if (recipe.pricePerCup >= 1.00 && recipe.pricePerCup <= 2.00)
            {
                Random random = new Random();
                totalCustomersForPrice = random.Next(30, 40);
                Console.WriteLine("You sold " + totalCustomersForPrice + " cups of lemonade.");
                Console.ReadLine();
            }
            if (recipe.pricePerCup > 2.00 && recipe.pricePerCup <= 3.00)
            {
                Random random = new Random();
                totalCustomersForPrice = random.Next(4, 30);
                Console.WriteLine("You sold " + totalCustomersForPrice + " cups of lemonade.");
                Console.ReadLine();
            }
            else if (recipe.pricePerCup > 3.00)
            {
                Console.WriteLine("You sold no lemonade, maybe lower the price.");
                Console.ReadLine();
            }
            else
            {

            }

            //public void NumberOfCustomersForTaste()
            //{
            //    Random random = new Random();
            //    totalCustomersForRecipe = random.Next(1, 30);

            //}


            //public void TasteTest()                   // do price and weather first before your try to do taste, taste is not required its extra
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








