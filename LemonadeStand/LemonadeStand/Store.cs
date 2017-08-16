using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        public double Cups = .05;
        public double numberOfCups;
        public double Ice = .02;
        public int numberofIce;
        public double Sugar = .40;
        public int numberOfSugar;
        public double Lemons = .75; //These four things need monetary values. Give it to them.
        public int numberOfLemons;
        public double Spent;
        public double balanceAfterCups;
        public double balanceAfterIce;
        public double balanceAfterSugar;
        public double balanceAfterLemons;
        Player playerOne;
        public Store(Player playerOne)
        {
            this.playerOne = playerOne;
        }
        public void displayBalance(Player Player)
        {
            Console.WriteLine($"you have{playerOne.Balance} ");
        }
        public void getNumberOfCups()
        {
            Console.WriteLine("How many Cups do you want? 25, 50, 100, or 200?");
            numberOfCups = double.Parse(Console.ReadLine());
            if (Cups != 25 || Cups != 50 || Cups != 100 || Cups != 200)
            {
                Console.WriteLine("Enter a valid choice: 25, 50, 100, or 200");
                getNumberOfCups();
            }
        }
        public void howMuchCups()// if we need to return something, make this into a double.
        {
            balanceAfterCups = playerOne.Balance - (numberOfCups * Cups);//Method will multiply getNumberOfCups by Cups.
        }
        public void getNumberOfIce()
        {
            Console.WriteLine("How much Ice do you want? 50, 100, 150, or 200?");
            numberOfCups = double.Parse(Console.ReadLine());
            if (Ice != 25 || Ice != 50 || Ice != 100 || Ice != 200)
            {
                Console.WriteLine("Enter a valid choice: 50, 100, 150, or 200");
                getNumberOfIce();
            }
        }
        public void howMuchIce()
        {
            balanceAfterIce = playerOne.Balance - (numberofIce * Cups);
        }
        public void getNumberOfSugar()
        {
            Console.WriteLine("How much Sugar do you want? 20, 50, or 100?");
            numberOfCups = double.Parse(Console.ReadLine());
            if (Sugar != 20 || Sugar != 50 || Sugar != 100)
            {
                Console.WriteLine("Enter a valid choice: 50, 100, 150, or 200");
                getNumberOfSugar();
            }
        }
        public void howMuchSugar()
        {
            balanceAfterSugar = playerOne.Balance - (numberOfSugar - Sugar);
        }
        public void getNumberOfLemons()
        {
            Console.WriteLine("How many Lemons do you want? 10, 30, 70, or 100?");
            numberOfCups = double.Parse(Console.ReadLine());
            if (Ice != 25 || Ice != 50 || Ice != 100 || Ice != 200)
            {
                Console.WriteLine("Enter a valid choice: 50, 100, 150, or 200");
                getNumberOfSugar();
            }
        }
        public void howMuchLemons()
        {
            balanceAfterLemons = playerOne.Balance - (numberOfLemons * Lemons);
        }
        public void moneySpent()
        {
            Spent = (numberOfCups * Cups) + (numberofIce * Ice) + (numberOfLemons * Lemons) + (numberOfSugar * Sugar);
        }
        public void getBalance()// this method will subtract bought merch from player.Balance
        {
            double Balance = ((playerOne.Balance - balanceAfterCups) + (playerOne.Balance - balanceAfterIce) + (playerOne.Balance - balanceAfterSugar) + (playerOne.Balance - balanceAfterLemons));
            Console.WriteLine($"Your balance is{Balance}");
        }//Console.WriteLine($"{Player.Balance.ToString()}");//See objects.
        //double buyingCups = Player.Balance - Cups;
        //Console.ReadLine();
        //return balanceAfterCups;
        //MAYBE?? 
    }
}