using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Ninja naruto = new Ninja("Naruto");

            System.Console.WriteLine(naruto.strength);

            Samurai jack = new Samurai("jack");
            jack.howMany();

        }
    }
}
