using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            // Card testCard = new Card("Ace","Spades",1);
            // testCard.Print();
            // testCard.StringVal = "King";
            
            Deck simpleDeck = new Deck();
            simpleDeck.Shuffle();
            simpleDeck.PrintDeck();
        }
    }
}
