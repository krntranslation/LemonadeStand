using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    public class Player
    {
        //public Wallet wallet;
        public string name;
        public Inventory inventory;
        public Recipe recipe;
        public Pitcher pitcher;
        public Store store;
        public double sales;
        public double totalBusinessProfits;
        public double wallet;
        List<double> weeksales;
        public double businessProfits;


        public Player()
        {
            name = null;
            businessProfits = 0.00;  
            sales = 0;
            weeksales = new List<double>();
            totalBusinessProfits = 0;
            wallet = 30.00;
            
           

            inventory = null;


        }
        public void CheckInventory()
        {
            
        }
        public void DailyReport()
        {
            //businessProfits = (wallet - sales);  // remember what amount you started with before you purchased products
            if (businessProfits <= 0.00)
            {
                Console.WriteLine("No money left");
                Console.ReadLine();

            }
            if (businessProfits > 0.00)
            {
                Console.WriteLine("You made " + businessProfits + " today");
            }
            else
            {

            }

        }
        public void WeekReport()
        {
            Console.WriteLine("You made " + businessProfits + " today");
            weeksales.Add(businessProfits);
            
        }
        public void TotalReport()
        {
            totalBusinessProfits = weeksales.Sum();
            Console.WriteLine("You made a total of " + totalBusinessProfits);
            Console.ReadLine();
        }
        



    }
  
}
