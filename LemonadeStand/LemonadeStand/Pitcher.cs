using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Pitcher
    {
        Recipe recipe;

        public double newPitcher;
        public Pitcher()
        {

        }
        public void mix()
        {
            newPitcher = recipe.numbLemons + recipe.numbSugar + recipe.numbIce;
        }
    }
}
