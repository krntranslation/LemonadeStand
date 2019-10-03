using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    public class Inventory
    {
        //public List<Lemon>lemons 
        //public List<IceCube> iceCubes;
        //public List<Cup> cups;
        //public List<SugarCube> sugarCubes;
        public Player player;
        double amountOfLemons;
        double amountOfSugar;
        double amountOfIce;
        double amountOfCups;

       


        public Inventory()
        {
            amountOfLemons += player.store.lemonBagCount;
            amountOfSugar += player.store.sugarBagCount;
            amountOfIce += player.store.iceBagCount;
            amountOfCups += player.store.cupsCount;
            
        }
        
        

    
    
    
    
    }

        
 
}
