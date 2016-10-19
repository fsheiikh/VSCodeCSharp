using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {   Random random = new Random();
            Deck deck = new Deck();
            System.Console.WriteLine(deck.cards.First().name);

            Console.WriteLine(deck.deal().name);
            System.Console.WriteLine(deck.cards.First().name);
            deck.shuffle(random);
            System.Console.WriteLine(deck.cards.First().name);

            Player donald = new Player("Donald Trump");
            Console.WriteLine(donald.draw(deck).name);

            Console.WriteLine(donald.discard(deck.cards.First()));

        }
    }
}
