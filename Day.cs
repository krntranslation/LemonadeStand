using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    public class Day
    {
        public Weather weather;
        public string customers;
        //public string currentDay;
        public List<string> days = new List<string> { };            /*{ "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };*/


        public Day()
        {
            weather.WhatsTheWeather();

        }
        public void WhichDayIsIt()
        {
            //int i = 0;
            //while (i < 7)
            //{
            //    i++;
            //    Game.currentDay = i;
            //    Console.WriteLine("Today is" + " " + Game.currentDay);
            //    Console.ReadLine();
            //    break;

            //}



        }
    }
}
            