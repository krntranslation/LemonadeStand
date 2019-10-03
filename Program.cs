using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    class Program
    {
        static void Main(string[] args)
        {

            Game game = new Game();
            game.StartGame();
            Day day = new Day();
            day.WhichDayIsIt();
            Weather weather = new Weather();
            weather.WhatsTheWeather();
            Weather temperature = new Weather();
            temperature.RandomTemperature(65, 105);
            Recipe recipe = new Recipe();
             
           
            //Menu.SetOrder("Welcome to the store.\nYou will buy items here \nLemon Bag is 1 the cost is $3.00 and a bag has 30 lemons\nSugar Bag is 2 the cost is $2.00 and has 30 servings\nIce Bag is 3 the cost is $1.00 and has 300 ice cubes\nIf done enter in 4 \nPlease imput the number for the item");
            Store store = new Store();
            store.StoreItemsMenu();
        }
    }
}
