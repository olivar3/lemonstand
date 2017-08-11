using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        public double Cups = 0;
        public int numberOfCups;
        public double Ice = 0;
        public int numberofIce;
        public double Sugar = 0;
        public int numberOfSugar;
        public double Lemons = 0; //These four things need monetary values. Give it to them.
        public int numberOfLemons;
        public double balanceAfterCups;
        public double balanceAfterIce;
        public double balanceAfterSugar;
        public double balanceAfterLemons;
        public Store()
        {

        }
        public void displayBalance(Player Player)
        {
            Console.WriteLine($"you have{Player.Balance} ");
        }
        public double getCups(Player Player, Game Game)//There will be a null value somewehre here.
        {
            Console.WriteLine("How many Cups do you want? 25, 50, 100, or 200?");
            double buyCups = double.Parse(Console.ReadLine());
            if (Cups != 25 || Cups != 50 || Cups != 100 || Cups != 200)
            {
                Console.WriteLine("Enter a valid choice: 25, 50, 100, or 200");
            }
            else if (Cups == 25)
            {
                return numberOfCups;
            }
            else if (Cups == 50)
            {
                return numberOfCups;
            }
            else if (Cups == 100)
            {
                return numberOfCups;
            }
            else if (Cups == 200)
            {
                return numberOfCups;
            }
            else
            {
                return numberOfCups;
            }
        }
        public void getIce()
        {

        }
        public void getSugar()
        {

        }
        public void getLemons()
        {

        }
        public void getBalance(Player Player)// this method will subtract bought merch from player.Balance
        {
            double Balance = (Player.Balance - balanceAfterCups);
            Console.WriteLine("Your balance is");
       }//Console.WriteLine($"{Player.Balance.ToString()}");//See objects.
        //double buyingCups = Player.Balance - Cups;
        //Console.ReadLine();
        //return balanceAfterCups;
    }
}
