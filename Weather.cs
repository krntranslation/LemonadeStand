using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    public class Weather
    {   //Member Variables
        public string condition;
        public double temperature;
        private List<string> weatherConditions;
        public string predictedForcast;
        

        
        string conditions;
        string cloudy;
        string sunny;
        string raining;
        string todaysWeather;
        //Constructor
        public Weather()
        {
            temperature = 0;
            cloudy = null;
            sunny = null;
            raining = null;
            todaysWeather = null;
            conditions = null;


        }
        //Member Methods
        public void WhatsTheWeather()
        {
            //var random = new Random();
            //var list = new List<string>() { "Temp-89 degrees,\ncloudy", "Temp-66 degrees, \nsunny", "Temp-99 degrees, \nraining", "Temp-60 degrees, \ncloudy", "Temp-90 degrees, \nsunny", "Temp-75 degrees, \nraining", "Temp-87 degrees, \nsunny" };
            //int index = random.Next(list.Count);
            //Console.WriteLine("Todays Weather is" + " " + list[index]);
            //Console.ReadLine();

            //List<string> conditions = new List<string>() { "sunny", "raining", "cloudy" };

        }
        public void RandomTemperature(int min, int max)
        {
  
            Random random = new Random();
            temperature = random.Next(65, 105);
            Console.WriteLine("Todays Temperature is" + " " + temperature);
            Console.ReadLine();

        }
        
                
            
             
            



            //random generate the weather included both conditions and temperature






            //make a list of weather temp/conditions/

    }
       
}




















