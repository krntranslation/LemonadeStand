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
        //public List<string> days = new List<string>() { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        //int currentDay;

        public Game()
        {
            //days = null;
           // currentDay = 0;
           
        }
        public void StartGame()
        {
            Console.WriteLine("Welcome to your Lemonade Stand \nYou have 7 days to play,\nEach day you will buy supplys,\nYou will start with 20.00 dollars, \nThen you will make your own special blend of Lemonade,\nand change your price base on the current weather conditions.\nPress enter to start game");
            Console.ReadLine();
            Console.WriteLine("Please type in your name");
            player.name = Console.ReadLine();
            Console.WriteLine("Welcome" + " " + player.name + " " + "Lets make some money");
  

        }
        public void WhichDayIsIT()
        {

        }
        public void HowsTheWeather()
        {

        }
        public void PurchaseSupplies()
        {

        }
        public void SecretLemonadeBlend()
        {

        }

    }
}
