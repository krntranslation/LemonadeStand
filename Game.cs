using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    public class Game 
    {
        Player player = new Player();
        
        public int currentDay;

        public string name;

        public List<Day> days = new List<Day>();


        public Game()
        {

            currentDay = 0;
            name = null;

        }
        
        public void StartGame()
        {
            Console.WriteLine("Welcome to your Lemonade Stand \nYou have 7 days to play,\nEach day you will buy supplys,\nYou will start with 20.00 dollars, \nThen you will make your own special blend of Lemonade,\nand change your price base on the current weather conditions.\nPress enter to start game");
            Console.ReadLine();
            Console.WriteLine("Please type in your name");
            player.name = Console.ReadLine();
            Console.WriteLine("Welcome" + " " + player.name + " " + "Lets make some money");
            //WhichDayIsIt();//need to fix wont give each day
            Weather weather = new Weather(); 
            weather.WhatsTheWeather();
            //Weather temperature = new Weather();// shouldn't be here
            //temperature.RandomTemperature(65, 105);           
            //Recipe recipe = new Recipe();
            //Store store = new Store();
            //store.StoreItemsMenu();

        }

            



    }
}
