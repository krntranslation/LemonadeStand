using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    public class Player
    {
        public string name;
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;
        public Pitcher pitcher;
        public double businessProfits;
        public Store store;
        public double sales;
        List<double> weeksales;
        public double totalBusinessProfits;
        



        public Player()
        {
            name = null;
            businessProfits = 0.00;  
            sales = 0;
            weeksales = new List<double>();
            totalBusinessProfits = 0;


        }
        public void CheckInventory()
        {
            
        }
        public void DailyReport()
        {
            businessProfits = (wallet.moneyInWallet - sales);  // remember what amount you started with before you purchased products
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
