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

            //Game game = new Game();
            //game.StartGame();
            //game.WhatsTheDay();
            //Weather weather = new Weather();
            //weather.WhatsTheWeather();
            Weather temperature = new Weather();
            temperature.RandomTemperature(65, 105);
          
        }
    }
}
