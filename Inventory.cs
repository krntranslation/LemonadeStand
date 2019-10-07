using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    public class Inventory
    {
        //public List<Lemon> lemons;
        public List<IceCube> iceCubes;
        public List<Cup> cups;
        public List<SugarCube> sugarCubes;
        public Player player;
        public double amountOfLemons;
        public double amountOfSugar;
        public double amountOfIce;
        public double amountOfCups;
        Store store = new Store();
        public double lemons;
        
       
        


        public Inventory()
        {
            lemons = 0;
            amountOfLemons = 0; //+= player.store.lemonBagCount;
            amountOfSugar = 0; //+= player.store.sugarBagCount;
            amountOfIce = 0;//+= player.store.iceBagCount;
            amountOfCups = 0;//+= player.store.cupsCount;
            
        }
        public void MultiplyingBags()
        {
            amountOfLemons = (store.lemonBagCount * 30);
            amountOfSugar = (store.sugarBagCount * 30);
            amountOfIce = (store.iceBagCount * 300);
            amountOfCups = (store.cupsCount * 300);
        }
        
        
        

    
    
    
    
    }

        
 
}
