using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
    public class Deck
    {
        public List<Card> cards {get; set;}
        public string[] suits = {"Clubs", "Spades", "Hearts", "Diamonds"};
        public string[] values = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};

        public Deck()
        {   
            setDeck();
        }

        //selects the "top-most" card, removes it, and returns it
        public Card deal()
        {
            Card firstCard = cards.FirstOrDefault();
            cards.Remove(firstCard);
            return firstCard;
        }

        public void reset()
        {
            setDeck();
        }

        //sets deck to default 52 cards
        public void setDeck()
        {
            cards = new List<Card>();
            
            foreach (var s in suits)
            {   
                int count = 1;
                foreach (var v in values)
                {
                    cards.Add(new Card {value= v, suit= s, name= v + " of " + s, numerical_value= count});
                    count++;
                }
            }
        }

        //fisher yates shuffle
        public void shuffle(Random random)
        {
            for (int i = cards.Count; i > 1; i--)
            {
                int pos = random.Next(i);
                var x = cards[i - 1];
                cards[i - 1] = cards[pos];
                cards[pos] = x;
            }
        }

    }
}
