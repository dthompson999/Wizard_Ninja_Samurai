using System;
using wizard_ninja_samurai.Models;

namespace wizard_ninja_samurai
{
    class Program
    {

        static void ConsoleYellow(string text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(text);
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            Human newHuman = new Human("Jon Snow");
            // newHuman.GetInfo();
            Human deadHuman = new Human("Night King", 15, 5, 10, 100);
            deadHuman.GetInfo();
            // newHuman.Attack(deadHuman);
            // newHuman.Attack(deadHuman);


            Ninja n1 = new Ninja("Ygritte");
            // n1.GetInfo();

            Wizard w1 = new Wizard("Gandolf");
            // w1.GetInfo();

            Samurai s1 = new Samurai("Watanabe");
            // s1.GetInfo();
            s1.Attack(deadHuman);
            s1.Attack(deadHuman);
            s1.Attack(deadHuman);
            s1.Attack(deadHuman);
            s1.Attack(deadHuman);
            s1.Attack(deadHuman);
            deadHuman.GetInfo();
            w1.Heal(deadHuman);
            deadHuman.GetInfo();
            deadHuman.Attack(s1);
            s1.Meditate();
            s1.GetInfo();
            n1.GetInfo();
            n1.Steal(s1);
            n1.Steal(s1);
            n1.Steal(s1);
            n1.Steal(s1);
            n1.Steal(s1);
            n1.Steal(s1);
            n1.Steal(s1);
            n1.GetInfo();
            s1.GetInfo();
        }
    }
}
