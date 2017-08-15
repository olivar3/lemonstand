using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Recipe
    {
        Inventory inventory;
        public double lemonadeRecipe;
        public double recpipe;
        public double perfectRecipe;
        public Recipe()
        {

        }
        public void givenRecipe()
        {
            lemonadeRecipe = (inventory.lemons - 6) + (inventory.sugar - 1) + (inventory.ice - 10);
        }
        public void newRecipe()
        {
            Console.WriteLine("Would you like to make a new recipe?");
            string yes = Console.ReadLine();
            switch (yes)
            {
                case "yes":
                    int newLemons = Console.WriteLine($"how many lemons?");
                    int newSugar = inventory.sugar;
                    int newIce = inventory.ice;
                    lemonadeRecipe = (newLemons - inventory.lemons) + (newSugar - inventory.sugar) + (newIce - inventory.ice);

            }
        }
        public void Perfect()
        {
            perfectRecipe = (inventory.lemons - 8) + (inventory.sugar - 1) + (inventory.ice - 15);
        }

    }
}