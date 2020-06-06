using System;

namespace wizard_ninja_samurai.Models
{
    class Wizard : Human
    {
        public Wizard(string name) : base(name)
        {
            Intelligence = 25;
            health = 50;
        }

        public override int Attack(Human target)
        {
            int dmg = 5 * Intelligence;
            int TargetHealth = target.health -= dmg;
            health += dmg;
            ConsoleYellow($"Wizard {Name} attacked {target.Name} for {dmg} damage!");
            Console.WriteLine($"{target.Name}'s current health is {TargetHealth}");
            return TargetHealth;
        }

        public void Heal(Human target)
        {
            ConsoleYellow($"Wizard {Name} is healing {target.Name}");
            target.health += 10 * Intelligence;
        }

        static void ConsoleYellow(string text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}