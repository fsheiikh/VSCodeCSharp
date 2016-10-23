using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Human> Heros = new List<Human>()
            {
                new Wizard("Gandalf"),
                new Ninja("Sasuke"),
                new Samurai("Jack")
            };

            List<Enemy> Enemies = new List<Enemy>()
            {
                new Zombie("Donald"),
                new Zombie("Hillary"),
                new Spider("Charlotte")
            };

            Console.WriteLine("Our Heros: ");
            Heros.ForEach(h => {Console.WriteLine(h.name);});

            Console.WriteLine("\n\nOur Enemies: ");
            Enemies.ForEach(e => {Console.WriteLine(e.name);});

            Random random = new Random();
            // while(Heros.All(h => h.health > 0) || Enemies.All(h => h.health > 0))
            // {
            //     for (int i = 0; i < Heros.Count(); i++)
            //     {
            //         Enemies.ElementAt(i).eat(Heros, random);
            //         System.Console.WriteLine(Enemies.ElementAt(i).name + " attacked");
            //     }

            //     for (int i = 0; i < Enemies.Count(); i++)
            //     {
            //         Heros.ElementAt(i).attack(Enemies.Take(random.Next(Enemies.Count()-1)));
            //         System.Console.WriteLine(Heros.ElementAt(i).name + " attacked");
            //     }
            // }


        }
    }
}
