using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        public string Sunny;
        public string PartlyCloudy;
        public string Cloudy;
        public string Rainy;
        public int temp;
        public int Hot;
        public int Warm;
        public int Fair;
        public int Cool;
        public int Cold;
        public int tempCustomer;
        public Weather()
        {

        }
        public void tempIs()
        {
            tempCustomer = displayTemp();
        }
        public int displayTemp()
        {
            if(temp <= 59)
            {
                Console.WriteLine($"{Cold}");
                return Cold;
            }
            else if(temp <= 68 || temp >= 60)
            {
                Console.WriteLine($"{Cool}");
                return Cool;
            }
            else if(temp <= 75 || temp >= 69)
            {
                Console.WriteLine($"{Fair}");
                return Fair;
            }
            else if (temp <= 85 || temp >= 76)
            {
                Console.WriteLine($"{Warm}");
                return Warm;
            }
            else
            {
                Console.WriteLine($"{Hot}");
                return Hot;
            }
        }
        public void getTemperature()
        {
            Random random = new Random();
            temp = random.Next(45, 110);
        }
    }
}