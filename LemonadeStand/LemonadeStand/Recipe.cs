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
        public double currentRecipe;
        public double perfectRecipe;
        public double Stars;
        public double numbLemons;
        public double numbSugar;
        public double numbIce;
        public Recipe()
        {

        }
        public void getNumLemForRecipe()
        {
            Console.WriteLine("How many lemons do you want in the recipe?");
            numbLemons = double.Parse(Console.ReadLine());
            getNumSugForRecipe();
        }
        public void getNumSugForRecipe()
        {
            Console.WriteLine("How much sugar do you want in the recipe?");
            numbSugar = double.Parse(Console.ReadLine());
            getNumIceForRecipe();
        }
        public void getNumIceForRecipe()
        {
            Console.WriteLine("How much Ice do you want in the recipe?");
            numbIce = double.Parse(Console.ReadLine());
            givenRecipe();
        }
        public void givenRecipe()
        {
            currentRecipe = numbLemons + numbSugar + numbIce;
        }
        public void newRecipe()
        {
            Console.WriteLine("Would you like to make a new recipe?");
            string yes = Console.ReadLine();
            switch (yes)
            {
                case "yes":
                    getNumLemForRecipe();
                    break;
                case "no":
                    break;

            }
        }
        public void Perfect()
        {
            perfectRecipe = (numbLemons = 8) + (numbSugar = 1.5) + (numbIce = 20);
        }
        public void closePerfect()
        {
            if (numbLemons == 7 && numbSugar == 1 || numbLemons == 9 && numbSugar == 1.5 || numbLemons == 10 && numbSugar == 2)
            {
                Stars = 4;
            }

            else if (numbLemons == 11 || numbLemons == 12)
            {
                Stars = 3;
            }
            else if(numbLemons == 6)
            {
                Stars = 2;
            }
            else
            {
                Stars = 1;
            }


        }

    }
}