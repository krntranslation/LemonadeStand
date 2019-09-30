using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    class Weather
    {   //Member Variables
        string temperature;
        string cloudy;
        string sunny;
        string raining;
        string todaysWeather;
        //Constructor
        public Weather()
        {
            temperature = null;
            cloudy = null;
            sunny = null;
            raining = null;
            todaysWeather = null;


            List<string> weatherList = new List<string>() { "Temp-89 degrees,\n cloudy", "Temp-66 degrees, \n sunny", "Temp-99 degrees, \n raining", "Temp-60 degrees, \n cloudy", "Temp-90 degrees, \n sunny", "Temp-75 degrees, \n raining", "Temp-87 degrees, \n sunny" };
        }
        //Member Methods
        public void WhatsTheWeather()
        {
            var random = new Random();
            var list = new List<string>() { "Temp-89 degrees,\ncloudy", "Temp-66 degrees, \nsunny", "Temp-99 degrees, \nraining", "Temp-60 degrees, \ncloudy", "Temp-90 degrees, \nsunny", "Temp-75 degrees, \nraining", "Temp-87 degrees, \nsunny" };
            int index = random.Next(list.Count);
            Console.WriteLine("Todays Weather is"+" " + list[index]);
            Console.ReadLine();

        }
       
    }



















}
