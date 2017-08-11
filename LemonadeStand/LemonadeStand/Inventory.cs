using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        Store store;
        Player playerOne;
        public int lemons;
        public int ice;
        public int sugar;
        public int cups;
        public int basket;
        //int Lemons = 12;
        //int Ice = 20;
        //int Sugar = 2;
        //int Cups = 25;
        public Inventory()
        {
            store = new Store(playerOne);
        }
        public void takeInventory()
        {
            basket = lemons + ice + sugar + cups;
            showInventory();
        }
        public void showInventory()
        {
            Console.WriteLine($"You have {basket.ToString()}");
        }

        public void rottingInventory()//this will take count of how many days certain things have been here, IF # of Days after purchase > set # of Days, x,y,z is rotten
        {

        }
        public void subtractFromInventory()
        {

        }
        public void askIfPlayerNeedsMore()
        {

        }
    }
}
