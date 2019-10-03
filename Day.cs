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
        public string currentDay;
        public List<string> days = new List<string> { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };


        public Day()
        {

            currentDay = null;

        }

        public void WhichDayIsIt()
        {
            int i = 0;
            while (i <= days.Count)
            {
                i++;
                currentDay = days[i];
                Console.WriteLine("Today is" + " " + currentDay);
                Console.ReadLine();
                break;
                
            }
             


        }
    }
}
            