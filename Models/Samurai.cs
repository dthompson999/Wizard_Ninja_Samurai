using System;

namespace wizard_ninja_samurai.Models
{
    class Samurai : Human
    {
        public Samurai(string name) : base(name)
        {
            health = 200;
        }

        public override int Attack(Human target)
        {
            base.Attack(target);
            if (target.health < 50)
            {
                target.health = 0;
            }
            return target.health;
        }

        public void Meditate()
        {
            ConsoleYellow($"Samurai {Name} is meditating.");
            health = 200;
        }

        static void ConsoleYellow(string text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}