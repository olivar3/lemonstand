using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Time
    {
        Game game;
        Player playerOne;
        Store store;
        Day day;
        public Time()
        {
            playerOne = new Player();
            store = new Store(playerOne);
            day = new Day();
        }
        public void getTime()
        {

        }
        public void lengthOfGame()
        {
            Console.WriteLine("Choose the length of your game in days. you may chose between 30 and 90 days. ");
            int numberOfDays = int.Parse(Console.ReadLine());
            if (numberOfDays < 30)
            {
                Console.WriteLine("Please enter a valid timeline, between 30 and 90.");
            }
            else if (numberOfDays > 90)
            {
                Console.WriteLine("Please enter a valid timeline, between 30 and 90.");
            }
            else
            {
                //runGame();
            }
        }
    }

}