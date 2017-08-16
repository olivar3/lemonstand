using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day //thihs is only for player purposes. weather will have to do with customers and Time.
    {
        Customer customer;
        Store store;
        public double dailyProfit;

        public Day()
        {
           
        }
        public void profitsForDay()
        {
           dailyProfit = customer.earnings - store.Spent;
        }

    }
}
