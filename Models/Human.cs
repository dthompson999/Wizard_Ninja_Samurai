using System;

namespace wizard_ninja_samurai.Models
{
    class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        public int health;
        public int Health
        {
            get {return health;}
        }

        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }

        public Human(string name, int str, int intel, int dex, int hp)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            health = hp;
        }

        public virtual int Attack(Human target)
        {
            int dmg = 3 * Strength;
            int TargetHealth = target.health -= dmg;
            ConsoleYellow($"{Name} attacked {target.Name} for {dmg} damage!");
            Console.WriteLine($"{target.Name}'s current health is {TargetHealth}");
            return TargetHealth;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Strength: {Strength}");
            Console.WriteLine($"Intelligence: {Intelligence}");
            Console.WriteLine($"Dexterity: {Dexterity}");
            Console.WriteLine($"Health: {health}");
        }

        static void ConsoleYellow(string text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
