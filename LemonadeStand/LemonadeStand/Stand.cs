using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Stand
    {
        Customer customer;
        public double lemonadePrice;
        public int pitcher;
        public Stand()
        {

        }
        public void Price()
        {
            lemonadePrice = .50;
        }
        public void changePrice()
        {
            double newlemonadePrice = lemonadePrice;
        }
        public void inPitcher()
        {
            pitcher = customer.cupsBought - pitcher;
        }

    }
}