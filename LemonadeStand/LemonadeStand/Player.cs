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
        public Player()
        {

        }

        public void increaseProfits()
        {

        }
        public void getProfits()
        {

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

