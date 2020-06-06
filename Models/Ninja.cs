using System;

namespace wizard_ninja_samurai.Models
{
    class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            Dexterity = 175;
        }

        public override int Attack(Human target)
        {
            int dmg = 5 * Dexterity;
            int TargetHealth = target.health -= dmg;
            ConsoleYellow($"Ninja {Name} attacked {target.Name} for {dmg} damage!");
            Console.WriteLine($"{target.Name}'s current health is {TargetHealth}");
            return TargetHealth;
        }

        public void Steal(Human target)
        {
            int StealAmt = 5; 
            ConsoleYellow($"Ninja {Name} is stealing {StealAmt} health from {target.Name}.");
            target.health -= StealAmt;
            health += StealAmt;
        }

        static void ConsoleYellow(string text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}