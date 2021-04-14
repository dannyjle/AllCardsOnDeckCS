using System;
using System.Collections.Generic;

namespace AllCardsOnDeckCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------- All Cards On Deck -------");

            var cards = new List<string>() { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };

            var suits = new List<string>() { "Spades", "Clubs", "Diamonds", "Hearts" };

            var cardList = new List<String>();

            for (var index = 0; index < cards.Count; index++)
            {
                for (var cardIndex = 0; cardIndex < suits.Count; cardIndex++)
                {
                    var allCards = $"{} of {}"
                    cardList.Add()
                }



            }

        }
    }
}
