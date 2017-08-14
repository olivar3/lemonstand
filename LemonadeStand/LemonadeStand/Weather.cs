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
        public Weather()
        {

        }
        public void displayTemp()
        {
            if(temp <= 59)
            {
                Console.WriteLine($"{Cold}");
            }
            else if(temp <= 68 || temp >= 60)
            {
                Console.WriteLine($"{Cool}");
            }
            else if(temp <= 75 || temp >= 69)
            {
                Console.WriteLine($"{Fair}");
            }
            else if (temp <= 85 || temp >= 76)
            {
                Console.WriteLine($"{Warm}");
            }
            else
            {
                Console.WriteLine($"{Hot}");
            }
        }
        public void getTemperature()
        {
            Random random = new Random();
            temp = random.Next(45, 110);
        }
    }
}