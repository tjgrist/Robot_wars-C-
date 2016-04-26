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
        public int dealt_damage;


           public Robot choose_bot()
        {
            Console.WriteLine("Choose a robot: 'Battlebot', 'Speedbot', or 'Repeaterbot'");
            var choice_bot = Console.ReadLine();
            if (choice_bot.ToLower().Replace(" ","") == "battlebot")
            {
                return new Battlebot();
            }
            else if (choice_bot.ToLower() == "speedbot")
            {
                return new Speedbot();
            }
            else
            {
                return new Repeaterbot();
            }
        }

        public string choose_weapon()
        {
            Console.WriteLine("Enter a new weapon for your robot: ");
            weapon = Console.ReadLine();
            return weapon;
        }

        public void get_name()
        {
            Console.WriteLine("Enter the name for you robot: ");
            name = Console.ReadLine();
        }

        public void set_hitpoints()
        {
            Random number_generator = new Random();
            hit_points = number_generator.Next(50, 100);
        }
    
        public void set_war_cry()
        {
            Console.WriteLine("Enter your bot's war cry: ");
            war_cry = Console.ReadLine();
        }
        public void set_attributes()
        {
            get_name();
            set_hitpoints();
            set_war_cry();
            choose_weapon();
        }

        public void print_attributes()
        {
            Console.WriteLine("\nName: " + name);
            Console.WriteLine("Hit points: " + hit_points);
            Console.WriteLine("Weapon: " + weapon);
            Console.WriteLine("War cry: " + war_cry);
        }
 
        public void attack()
        {
            List<string> attacks = new List<string>
            {
               "\nAttacks!","\nSpeed and metal and the smell of oil!!","\nTHIS IS THE ARENA!\n"
            };
            foreach (string item in attacks)
            {
                Console.WriteLine(item);
            }

       }

       public void subtract_hitpoints()
        {
            hit_points -= 10;
        }

    }
}
