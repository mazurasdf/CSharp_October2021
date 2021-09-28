using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Deck
    {
        private List<Card> cards;

        public Deck()
        {
            Console.WriteLine("hello from the deck class!");
            cards = new List<Card>();
            populateDeck();
        }

        private void populateDeck()
        {
            //loop through array of all 4 suits
                //loop through 1-13
                    //new card with suit and value

            string[] suits = {"Spades","Diamonds","Hearts","Clubs"};

            foreach(string suit in suits)
            {
                for(int i = 1; i < 14; i++)
                {
                    // Console.WriteLine($"{i} of {suit}");
                    string stringVal;

                    if(i > 1 && i < 11)
                    {
                        stringVal = i.ToString();
                    }
                    else if(i == 1)
                    {
                        stringVal = "Ace";
                    }
                    else if(i == 11)
                    {
                        stringVal = "Jack";
                    }
                    else if(i == 12)
                    {
                        stringVal = "Queen";
                    }
                    else
                    {
                        stringVal = "King";
                    }

                    cards.Add(new Card(stringVal, suit, i));
                }
            }
        }

        public void Shuffle()
        {
            Console.WriteLine("everyday I'm shuffling!");
            List<Card> newList = new List<Card>();
            Random rand = new Random();

            while(cards.Count > 0)
            {
                int randIndex = rand.Next(cards.Count);
                // Console.WriteLine(randIndex);
                newList.Add(cards[randIndex]);
                cards.RemoveAt(randIndex);
            }

            cards = newList;
        }

        public void PrintDeck()
        {
            foreach(Card card in cards)
            {
                card.Print();
            }
        }
    }
}