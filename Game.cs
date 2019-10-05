using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    public class Game 
    {
        Player player = new Player();
        public int currentDay;
        List<Day> days;
        Store store = new Store();
        public string name;
        public List<string> daysName = new List<string> { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

        public Game()
        {
            days = new List<Day>();
            currentDay = 0;
            name = null;

        }
        
        public void StartGame()
        {
            Console.WriteLine("Welcome to your Lemonade Stand \nYou have 7 days to play,\nEach day you will buy supplys,\nYou will start with 30.00 dollars, \nThen you will make your own special blend of Lemonade,\nremember to change your price base on the current weather conditions.\nPress enter to start game");
            Console.ReadLine();
            Console.WriteLine("Please type in your name");
            player.name = Console.ReadLine();
            Console.WriteLine("Welcome" + " " + player.name + " " + "Lets make some money");
            CreateDays();
            RunDays();
            //StoreItemsMenu();
        }

        public void CreateDays()
        {
            for (int i = 0; i < 7; i++)
            {
                Day day = new Day(daysName[i]);
                days.Add(day);
            }
        }
        public void RunDays()
        {
            for (int i = 0; i < days.Count; i++)
            {
                Console.WriteLine("Today is " + daysName[i]);
                Console.ReadLine();
                days[i].RunDay(); //I should add all this generated weather into a list for forcasted weather
                store.StoreItemsMenu();

            }
        }
        

            



    }
}
