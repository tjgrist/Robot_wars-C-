using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_wars
{
    class Robot
    {
        public int hit_points;
        public string name;
        public string war_cry;
        public string weapon;


        public string choose_weapon()
        {
            Console.WriteLine("Choose a weapon: ");
            weapon = Console.ReadLine();
            return weapon;
        }

        public void get_name()
        {
            Console.WriteLine("Enter the name for you robot: ");
            name = Console.ReadLine();
            if (name == null)
            {
                name = "Rumbletime";
            }
        }

        public void set_hitpoints()
        {
            Random number_generator = new Random();
            hit_points = number_generator.Next(50, 100);
        }

        public Robot choose_bot()
        {
            Console.WriteLine("Choose a robot: 'battlebot', 'speedbot', or 'repeaterbot'");
            var choice_bot = Console.ReadLine();
            if (choice_bot == "battlebot")
            {
                return new Battlebot();
            }
            else if (choice_bot == "speedbot")
            {
                return new Speedbot();
            }
            else
            {
                return new Repeaterbot();
            }

        }
        public void set_attributes()
        {
            get_name();
            set_hitpoints();
            Console.WriteLine("Enter your bot's war cry: ");
            war_cry = Console.ReadLine();
            Console.WriteLine("Enter a weapon for your robot: ");
            weapon = Console.ReadLine();
        }

        public void print_attributes()
        {
            Console.WriteLine("\nName: " + name);
            Console.WriteLine("Hit points: " + hit_points);
            Console.WriteLine("War cry: " + war_cry);
            Console.WriteLine("Weapon: " + weapon);
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
        public void set_war_cry()
        {
            List<string> cry_list = new List<string> { "I'm oiled up and ready for a rumble!!!",
                "Machine Learning will destroy you!","Robo rumbles always end in metal shards!","I want to eat your circuitry!" };
            Random index_maker = new Random();
            int index = index_maker.Next(0, 3);
            war_cry = Convert.ToString(cry_list[index]);
        }

        public void loop_battle(Robot your_bot, Robot cpu_bot)
        {
            int counter = 0;
            while (counter < 3)
            {
                battle(your_bot, cpu_bot);                
                your_bot.print_attributes();
                cpu_bot.print_attributes();
                your_bot.choose_weapon();
                cpu_bot.set_weapon();
                counter++;
            }
        }
        public void battle(Robot your_bot,Robot cpu_bot)
        {
            Console.WriteLine("\nAre you ready for a robo-rumble?");
            Console.WriteLine("{0} says: {1}",your_bot.name,your_bot.war_cry);
            Console.WriteLine("{0} says: {1}\n",cpu_bot.name,cpu_bot.war_cry);
            if (your_bot.weapon.Length == cpu_bot.weapon.Length)
            {
                Console.WriteLine("Tie!");
            }
            else if (your_bot.weapon.Length >= cpu_bot.weapon.Length)
            {
                Console.WriteLine("{0} deals damage to {1}!",your_bot.name, cpu_bot.name);
                cpu_bot.subtract_hitpoints();
            }
            else
                Console.WriteLine("{0} is damaged by {1}!",your_bot.name, cpu_bot.name);
                your_bot.subtract_hitpoints();               
        }

        public void subtract_hitpoints()
        {
            hit_points -= 10;
        }

    }
}
