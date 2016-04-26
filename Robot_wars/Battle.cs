using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_wars
{
    class Battle
    {
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
        public void battle(Robot your_bot, CPU cpu)
        {
            Console.WriteLine("\nARE YOU READY FOR A ROBO RUMBLE?");
            Console.WriteLine("{0} says: {1}", your_bot.name, your_bot.war_cry);
            Console.WriteLine("{0} says: {1}\n", cpu.name, cpu.war_cry);
            your_bot.attack();
            if (your_bot.weapon.Length == cpu.weapon.Length)
            {
                Console.WriteLine("Tie!");
            }
            else if (your_bot.weapon.Length >= cpu.weapon.Length)
            {
                Console.WriteLine("{0} deals damage to {1}!", your_bot.name, cpu.name);
                cpu.subtract_hitpoints();
            }
            else
            {
                Console.WriteLine("{0} is damaged by {1}!", your_bot.name, cpu.name);
                your_bot.subtract_hitpoints();
            }
        }
    }
}
