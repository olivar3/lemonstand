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
        public int numberOfDays;
        public int dayNumber;
        public Time()
        {
            playerOne = new Player();
            store = new Store(playerOne);
           // this.day = day();

        }
        public void getTime()
        {
            dayNumber = numberOfDays - dayNumber;
        }
        public void lengthOfGame()
        {
            Console.WriteLine("Choose the length of your game in days. you may chose between 7 and 90 days. ");
            numberOfDays = int.Parse(Console.ReadLine());
            if (numberOfDays < 7)
            {
                Console.WriteLine("Please enter a valid timeline, between 30 and 90.");
            }
            else if (numberOfDays > 90)
            {
                Console.WriteLine("Please enter a valid timeline, between 30 and 90.");
            }
            else
            {
                game.runGame();
            }
        }
        public void whatDayIsItToday()// this might be wrong. have to test it.
        {
            int i = dayNumber;
            for(i = 0; i <= numberOfDays; i++)
            {
                if (i <= numberOfDays)
                {
                    getTime();
                }
                else
                {
                    break;
                }
            }
        }
    }

}