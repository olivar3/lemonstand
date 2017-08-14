using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{ 
    public class Customer
    {
        Weather weather;
        public double profits;
        public int Customers =  200;
        public int passCustomer;
        public int buyCustomer;
        public Customer()
        {
        }
        public void numberOfCustomers()
        {
        //number of customers is 200 for a single day.
        }
        public void customerFeelings()
        {

            if (weather.Cold <= weather.tempCustomer)
            {
                //subtract customers who dont like cold
            }
            else if (weather.Cool <= weather.tempCustomer)
            {
                //sutbtract customers who dont like cool or cold
            }
            else if (weather.Fair <= weather.tempCustomer)
            {
                //subtract very little customers
            }
            else if (weather.Warm <= weather.tempCustomer)
            {
                //dont subtract anyone
            }
            else if(weather.Hot <= weather.tempCustomer)
            {
               // dont subtract anyone. 
            }

        //If weather is such and such number of customers - sunnyonlycustomers, fairweathercustomers, anyweathercustomers.?
        }
        public void passingCustomer()
        {
            //composed of those who dont like the current weather.
        }
        public void buingCustomer()
        {
            // If weather is such and such, # of customers - 
        }
        public void customerLikesPrice()
        {

        }
        public void Popularity()
        {
            // adds customers who would otherwise not come out on fair or cool days. Do i need this?
        }
    }
}
