using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Human Batman = new Human("BatMan");
            Human Joker = new Human("Joker");
            Console.WriteLine("Batman health: " + Batman.health);
            Console.WriteLine("Joker health: " + Joker.health);

            Batman.attack(Joker);
            System.Console.WriteLine("{0} attacks {1}", Batman.name, Joker.name);
            System.Console.WriteLine("Joker Health: " + Joker.health);
        }
    }
}
