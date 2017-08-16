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
        Stand stand;
        Recipe recipe;
        public double profits;
        public int Customers =  200;
        public int customersNoLikeCold = 70;
        public int customerNoLikecool = 30;
        public int customerNoLikeFair = 10;
        public int cheapCustomer = 100;
        public int trendyCustomer = 100;
        public int buyCustomer;
        public int purchasingCustomers;
        public int interestedCustomer;
        public int popularCustomer;
        public double earnings;
        public int cupsBought;
        public int popular;
        public Customer()
        {
        }
        public void numberOfCupsBought()
        {
            cupsBought = buyCustomer + interestedCustomer;
        }
        public void customerSpent()
        {
            earnings = purchasingCustomers * stand.lemonadePrice;
        }
        public void numberOfCustomers()
        {
            purchasingCustomers = (Customers - cheapCustomer) +(Customers - customerNoLikeFair) + (Customers - customerNoLikecool) + (Customers - customersNoLikeCold);
        }
        public void customerFeelings()
        {

            if (weather.Cold <= weather.tempCustomer)
            {
                Customers = Customers - customersNoLikeCold;
            }
            else if (weather.Cool <= weather.tempCustomer)
            {
                Customers = Customers - customerNoLikecool;
            }
            else if (weather.Fair <= weather.tempCustomer)
            {
                Customers = Customers - customerNoLikeFair;
            }
        }

        public void buingCustomer()
        {
            // If weather is such and such, # of customers - 
        }
        public void customerDoesntLikePrice()
        {
            if (stand.lemonadePrice >= 3.00)
            {
                Customers = Customers - cheapCustomer;
            }
        }
        public void Popularity()
        {
            if (recipe.currentRecipe == recipe.perfectRecipe)
            {
                popular = 5;
            }
            else
            {
                recipe.closePerfect();
            }
        }
        public void raitingForPopularity()
        {
            if (recipe.Stars == 4)
            {
                Customers -= 20;
            }
            else if(recipe.Stars == 3)
            {
                Customers -= 50;
            }
            else if(recipe.Stars <= 2)
            {
                Customers -= 100;
            }
        }
    }
}
