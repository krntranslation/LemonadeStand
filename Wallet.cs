using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    public class Wallet
    {
        private double cash;
        public double Cash

        {
            get { return this.cash; }    //CashReport();}
            set{ Cash = cash; }       //SetCash(30.00)
        }

        public Wallet()
        {
            this.cash = 30.00;
        }
        //private double CashReport()
        //{
        //    return cash;
        //}
        //private void SetCash(double cashIn)
        //{
        //    cash = cashIn;
        //}
    }
}