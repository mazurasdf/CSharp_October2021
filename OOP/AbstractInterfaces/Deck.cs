using System;
using System.Collections.Generic;

namespace AbstractInterfaces
{
    public class Card
    {
        private string stringVal;
        public string StringVal
        {
            get{return stringVal;}
        }
        private string suit;
        public string Suit
        {
            get{return suit;}
        }
        private int val;
        public int Val
        {
            get{return val;}
        }

        public Card(string newStringVal, string newSuit, int newVal)
        {
            val = newVal;
            stringVal = newStringVal;
            suit = newSuit;
        }

        public void Print()
        {
            Console.WriteLine($"{stringVal} of {suit}: {val}");
        }

    }

    public class Deck : IRandomizable
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

        public void RandomSet()
        {
            cards = new List<Card>();
            Random rand = new Random();
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

                    if(rand.Next(0,2) == 1)
                    {
                        cards.Add(new Card(stringVal, suit, i));
                    }
                }
            }
            Shuffle();
        }

        public void Randomize()
        {
            Shuffle();
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