using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    public class Wallet
    {
        private double moneyInWallet = 30.00;

        public double MoneyInWallet
        {
            set
            {
                moneyInWallet = value;
            }
        }
    }
}
