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

        public void loop_battle(Robot your_bot, CPU cpu)
        {
            int counter = 0;
            while (counter < 3)
            {
                battle(your_bot, cpu);                
                your_bot.print_attributes();
                cpu.print_attributes();
                your_bot.choose_weapon();
                cpu.set_weapon();
                counter++;
            }
        }
        public void battle(Robot your_bot,CPU cpu)
        {
            Console.WriteLine("\nAre you ready for a robo-rumble?");
            Console.WriteLine("{0} says: {1}",your_bot.name,your_bot.war_cry);
            Console.WriteLine("{0} says: {1}\n",cpu.name,cpu.war_cry);
            if (your_bot.weapon.Length == cpu.weapon.Length)
            {
                Console.WriteLine("Tie!");
            }
            else if (your_bot.weapon.Length >= cpu.weapon.Length)
            {
                Console.WriteLine("{0} deals damage to {1}!",your_bot.name, cpu.name);
                cpu.subtract_hitpoints();
            }
            else
                Console.WriteLine("{0} is damaged by {1}!",your_bot.name, cpu.name);
                your_bot.subtract_hitpoints();               
        }
        public void subtract_hitpoints()
        {
            hit_points -= 10;
        }

    }
}
