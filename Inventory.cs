using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    class Inventory
    {
        public List<Lemon> lemons;
        public List<IceCubes> iceCubes;
        public List<Cup> cup;
        public List<SugarCubes> sugarCubes;

        double amountOfLemons;
        double amountOfSugar;
        double amountOfIce;

        public Inventory()
        {
            amountOfLemons = 1000;
            amountOfSugar = 1000;
            amountOfIce = 1000;
        }
    }
        
 
}
