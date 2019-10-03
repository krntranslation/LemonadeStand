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
        public string weatherConditions;
        //public string predictedForcast;//didnt use yet maybe dont have too
        

        
        string conditions;
        string cloudy;
        string sunny;
        string raining;
        string todaysWeather;
        string currentConditions;
        //Constructor
        public Weather()
        {
            temperature = 0;
            cloudy = null;
            sunny = null;
            raining = null;
            todaysWeather = null;
            conditions = null;
            //predictedForcast = null;//didt use yet
            currentConditions = null;

        }
        //Member Methods
        public void WhatsTheWeather() 
        {
            RandomWeather();
            RandomTemperature(65,105);
            Console.WriteLine("Today's temperature is" + " " + temperature + " " + "Degrees" + " " + "and its going to be" + " " + currentConditions);
            Console.ReadLine();

        }
        public void RandomWeather()
        {
            Random random = new Random();
            var conditions = new List<string>{ "sunny", "raining", "cloudy" };
            int index = random.Next(conditions.Count);
            currentConditions = conditions[index];
        }
        public void RandomTemperature(int min, int max)
        {
            Random random = new Random();
            temperature = random.Next(65, 105);

        }
    
 

    }
       
}




















