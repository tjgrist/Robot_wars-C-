using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_wars
{
    class CPU : Robot
    {
        public CPU()
        {
            name = "EX MACHINA";
        }
    
        public Robot get_cpu_bot()
        {
            Console.WriteLine("\nThe CPU will now choose a robot.");
            Random number_maker = new Random();
            var cpu_bot = number_maker.Next(1, 3);
            switch (cpu_bot)
            {
                case 1:
                    return new Battlebot();
                case 2:
                    return new Speedbot();
                case 3:
                    return new Repeaterbot();
                default:
                    return new Repeaterbot();
            }
        }
        public void set_war_cry()
        {
            List<string> cry_list = new List<string> { "I'm oiled up and ready for a rumble!!!",
                "Machine Learning will destroy you!","Robo rumbles always end in metal shards!","I want to eat your circuitry!" };
            Random index_maker = new Random();
            int index = index_maker.Next(0, 3);
            war_cry = Convert.ToString(cry_list[index]);
        }
        public void set_random_attributes()
        {
            Random number_maker = new Random();
            hit_points = number_maker.Next(50, 100);
            set_weapon();
        }

        public void set_weapon()
        {
            Console.WriteLine("CPU is choosing a new weapon.");
            Random number_maker = new Random();
            int weaponizer = number_maker.Next(1, 3);
            switch (weaponizer)
            {
                case 1:
                    weapon = "trident";
                    break;
                case 2:
                    weapon = "supreme blade";
                    break;
                case 3:
                    weapon = "torkette";
                    break;
                default:
                    weapon = "metal shank";
                    break;

            }
            set_war_cry();
        }
        public void subtract_hitpoints()
        {
            hit_points -= 10;
        }
    }
}
