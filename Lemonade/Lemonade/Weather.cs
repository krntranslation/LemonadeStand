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
        public string predictedForcast; //didnt use yet 
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
             //conditions = null;
            predictedForcast = null;//didnt use yet
            currentConditions = null;
            totalCustomersForWeather = 0;

        }
        //Member Methods
        public void WhatsTheWeather() 
        {
            RandomWeather();
            RandomTemperature(65,105);
            Console.WriteLine("Today's temperature is" + " " + temperature + " " + "Degrees" + " " + "and its going to be" + " " + currentConditions);
            Console.ReadLine();
            NumberOfCustomers();


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
                Console.WriteLine("Based on the weather only " + totalCustomersForWeather + " customers will be walking by your lemonade stand");
                Console.ReadLine();
            }
            if (currentConditions == "sunny" && temperature < 88 && temperature >= 70)
            {
                totalCustomersForWeather = 80;
                Console.WriteLine("Based on the weather only " + totalCustomersForWeather + " customers will be walking by your lemonade stand");
                Console.ReadLine();
            }
            if (currentConditions == "sunny" && temperature < 70 && temperature >= 65)
            {
                totalCustomersForWeather = 70; 
                Console.WriteLine("Based on the weather only " + totalCustomersForWeather + " customers will be walking by your lemonade stand");
                Console.ReadLine();
            }
            if (currentConditions == "cloudy" && temperature >= 88)
            {
                totalCustomersForWeather = 80;
                Console.WriteLine("Based on the weather only " + totalCustomersForWeather + " customers will be walking by your lemonade stand");
                Console.ReadLine();
            }
            if (currentConditions == "cloudy" && temperature < 88 && temperature >= 70)
            {
                totalCustomersForWeather = 70;
                Console.WriteLine("Based on the weather only " + totalCustomersForWeather + " customers will be walking by your lemonade stand");
                Console.ReadLine();
            }
            if (currentConditions == "cloudy" && temperature < 70 && temperature >= 65)
            {
                totalCustomersForWeather = 60;
                Console.WriteLine("Based on the weather only " + totalCustomersForWeather + "  customers will be walking by your lemonade stand");
                Console.ReadLine();
            }
            if (currentConditions == "raining" && temperature >= 88)
            {
                totalCustomersForWeather = 70; 
                Console.WriteLine("Based on the weather only " + totalCustomersForWeather + "  customers will be walking by your lemonade stand");
                Console.ReadLine();
            }
            if (currentConditions == "raining" && temperature < 88 && temperature >= 70)
            {
                totalCustomersForWeather = 60;
                Console.WriteLine("Based on the weather only " + totalCustomersForWeather + "  customers will be walking by your lemonade stand");
                Console.ReadLine();

            }
            if (currentConditions == "raining" && temperature <= 70)
            {
                totalCustomersForWeather = 50;
                Console.WriteLine("Based on the weather only " + totalCustomersForWeather + " customers will be walking by your lemonade stand");
                Console.ReadLine();
            }
            else
            {

            }


        }



    }
       
}




















