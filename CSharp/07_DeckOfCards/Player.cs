using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
    public class Player
    {
        public string name {get; set;}
        public List<Card> hand {get; set;}

        public Player(string newName)
        {   
            hand = new List<Card>();
            name = newName;
        }

        //draws a card from a deck, adds it to the player's hand, and returns it
        public Card draw(Deck deck)
        {
            hand.Add(deck.deal());
            return hand.FirstOrDefault();
        }

        public bool discard(Card card)
        {
            if(hand.Any(c=>c.name == card.name))
            {
                hand.Remove(card);
                return true;
            }
            else
            {
                return false;
            } 
        }
    }
}
