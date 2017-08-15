using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player //needs an "allowance"
    {
        public int Score;
        public string name;
        public int number;
        public double Balance;
        public double dailyProfits;
        public double totalProfits;
        public Player()
        {

        }
        public void increaseProfits()
        {
            totalProfits = dailyProfits + totalProfits;
        }
        public double Money()
        {
            double? number = null;
            double startingBalance = number ?? 50.00;
            Console.WriteLine($"You have:'{startingBalance.ToString()}");
            return Balance;
        }

    }
}

