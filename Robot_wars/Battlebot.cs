using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_wars
{
    class Battlebot : Robot
    {
        
        public Battlebot()
        {
            name = "Mousafa";
            weapon = "Electro pulse";
            war_cry = "I WILL DESTROY YOU";
            hit_points = 75;
        }
        public void get_war_cry()
        {   war_cry = "YAAA BATTLEBOT RULES!";
            Console.WriteLine("Battlebot says: "+ war_cry);
        }
        public void subtract_hitpoints()
        {
            hit_points -= 10;
        }
    }
}
