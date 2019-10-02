using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    public class Day
    {
        //public Weather weather;
        //public List<Customer> customer;
        
           public List<string> days = new List<string>() { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
           string currentDay;

        public Day()
        {

        }
        public void WhichDayIsIt()
        {
            
            for (int i = 0; i <= days.Count; i++)
            {
                currentDay = days[i];
                Console.WriteLine("Today is" + " " + currentDay);
                Console.ReadLine();
                break;
            }
            

        }
    
    }
}
