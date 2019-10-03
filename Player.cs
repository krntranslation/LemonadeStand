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

        



        public Player()
        {
            name = null;
            businessProfits = 0.00;
            wallet.moneyInWallet = 30.00;
            pitcher.howManyPitchers = 0;
            sales = 0;


        }
        public void DailyReport()
        {
            businessProfits = (wallet.moneyInWallet - sales);
            if (businessProfits < 0.00)
            {
                Console.WriteLine("No money left");
                Console.ReadLine();

            }
            if (businessProfits > 0.00)
            {
                Console.WriteLine("You made " + businessProfits + " today");
            }

        }
        



    }
  
}
