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
        public string predictedForcast;
        

        
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
            predictedForcast = null;
            currentConditions = null;

        }
        //Member Methods
        public void WhatsTheWeather()//I want to combine temperatrue and conditions to get a weather for the day also using the varibles to be referenced to amount of customers avail that day.
        {
            RandomWeather();
            RandomTemperature(65,105);
            Console.WriteLine("Today's temperature is" + " " + temperature + " " + "Degrees" + " " + "and its going to be" + " " + currentConditions);
            Console.ReadLine();



            //var random = new Random();
            //var list = new List<string>() { "Temp-89 degrees,\ncloudy", "Temp-66 degrees, \nsunny", "Temp-99 degrees, \nraining", "Temp-60 degrees, \ncloudy", "Temp-90 degrees, \nsunny", "Temp-75 degrees, \nraining", "Temp-87 degrees, \nsunny" };
            //int index = random.Next(list.Count);
            //Console.WriteLine("Todays Weather is" + " " + list[index]);
            //Console.ReadLine();

            

        }
        public void RandomWeather()
        {
            Random random = new Random();
            var conditions = new List<string>{ "sunny", "raining", "cloudy" };
            int index = random.Next(conditions.Count);
            currentConditions = conditions[index];

            //Console.WriteLine("Todday the forcast is" + " " + list[index]);
            //Console.ReadLine();
        }
        public void RandomTemperature(int min, int max)
        {
  
            Random random = new Random();
            temperature = random.Next(65, 105);
            //Console.WriteLine("Todays Temperature is" + " " + temperature + " " + "Degrees");
           // Console.ReadLine();

        }
        public void PredictedForcast()
        {

        }
        
 

    }
       
}




















