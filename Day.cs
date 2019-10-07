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
        public string DayName;

        public Day(string dayName)
        {
            weather = new Weather();
            DayName = dayName;
        
        }
        public void RunDay()
        {
            weather.WhatsTheWeather();
            
        }
    }
}

