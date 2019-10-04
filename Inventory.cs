using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    public class Inventory
    {
        public List<Lemon> lemons;
        public List<IceCube> iceCubes;
        public List<Cup> cups;
        public List<SugarCube> sugarCubes;
        public Player player;
        public double amountOfLemons;
        double amountOfSugar;
        double amountOfIce;
        double amountOfCups;
        
      
        Store store = new Store();
        //Inventory inventory = new Inventory();
        


        public Inventory()
        {
            amountOfLemons = 0; //+= player.store.lemonBagCount;
            amountOfSugar = 0; //+= player.store.sugarBagCount;
            amountOfIce = 0;//+= player.store.iceBagCount;
            amountOfCups = 0;//+= player.store.cupsCount;
            
        }
        public void MultiplyingLemons()
        {
            amountOfLemons = (store.lemonBagCount * 30);
        }
        
        
        

    
    
    
    
    }

        
 
}
