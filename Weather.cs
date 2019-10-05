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
        public string predictedForcast; //didnt use yet maybe dont have too
        string conditions;
        string cloudy;
        string sunny;
        string raining;
        string todaysWeather;
        public string currentConditions;
        private List<string> weatherConditons;
        public double totalCustomersForWeather;



        //Constructor
        public Weather()
        {
            weatherConditons = null;
            temperature = 0;
            cloudy = null;
            sunny = null;
            raining = null;
            todaysWeather = null;
            conditions = null;
            predictedForcast = null;//didt use yet
            currentConditions = null;
            totalCustomersForWeather = 0;
            //this.currentConditions = currentConditions;
            //this.temperature = temperature;
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
        public void NumberOfCustomers()
        {
            if (currentConditions == "sunny" && temperature >= 88)
            {
                totalCustomersForWeather = 100;
            }
            if (currentConditions == "sunny" && temperature < 88 && temperature >= 70)
            {
                totalCustomersForWeather = 80;
            }
            if (currentConditions == "sunny" && temperature < 70 && temperature >= 65)
            {
                totalCustomersForWeather = 70;
            }
            if (currentConditions == "cloudy" && temperature >= 88)
            {
                totalCustomersForWeather = 80;
            }
            if (currentConditions == "cloudy" && temperature < 88 && temperature >= 70)
            {
                totalCustomersForWeather = 70;
            }
            if (currentConditions == "cloudy" && temperature < 70 && temperature >= 65)
            {
                totalCustomersForWeather = 60;
            }
            if (currentConditions == "raining" && temperature >= 88)
            {
                totalCustomersForWeather = 70;
            }
            if (currentConditions == "raining" && temperature < 88 && temperature >= 70)
            {
                totalCustomersForWeather = 60;
            }
            if (currentConditions == "raining" && temperature <= 70)
            {
                totalCustomersForWeather = 50;
            }
            else
            {

            }


        }



    }
       
}




















