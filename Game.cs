using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    class Game : Store
    {
 

        public Game()
        {
        
        }
        public void StartGame()
        {
            Console.WriteLine("Welcome to your Lemonade Stand \nYou have 7 days,\n each day you buy supplys,\nyou will start with 20.00 dollars, \nmake your own special blend of Lemonade,\nand change your price base on the current weather conditions.\nPress enter to start game");
            Console.ReadLine();
            Console.WriteLine("Please type in your name");
            Console.ReadLine();

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
