using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        Rules rules;
        Player playerOne;
        Store store;
        Day day;
        Time time;
        Weather weather;
        public Game()
        {
            rules = new Rules();
            playerOne = new Player();
            store = new Store(playerOne);
            time = new Time();
        }

        public void dayOne()
        {
            Console.WriteLine("This is your first Day! you will get enough materials for a few pitchers of lemonade, but the rest you have to save up for.");

        }
        public void Day()
        {
            Console.WriteLine($"Today is day #{time.dayNumber}");
        }
        public void Weather()
        {
            Console.WriteLine($"The weather for today is {weather.tempCustomer}");
        }
        public void Customers()
        {

        }
        public void buyInventory()
        {

        }
        public void changeRecipe()
        {

        }
        public void changePriceLemonade()
        {

        }
        public void compareRecipes()
        {

        }
        public void compareSpentToEanred()
        {

        }
        public void calculateNewBalance()
        {

        }
        public void whatNextAfterToday()
        {

        }
        public void runGame()
        {
            rules.displayRules();
            //while loop is supposed to go here. come back to this after we get the other stuff going.
        }
        public void askToPlayAgain()
        {

        }
    }
}
