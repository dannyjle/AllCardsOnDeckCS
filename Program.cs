using System;
using System.Collections.Generic;

namespace AllCardsOnDeckCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------- All Cards On Deck -------");

            var cards = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            var suits = new List<string>() { "Spades", "Clubs", "Diamonds", "Hearts" };

            var deckList = new List<String>();

            for (var d = 0; d < cards.Count; d++)
            {
                for (var b = 0; b < suits.Count; b++)
                {
                    var allCards = ($"{cards[d]} of {suits[b]}");
                    deckList.Add(allCards);
                }

            }

            foreach (var all in deckList)

            {
                Console.WriteLine($"{all}");
            }


            Console.WriteLine();


            var numberOfCards = cards.Count;

            for (var rightIndex = numberOfCards - 1; rightIndex >= 0; rightIndex--)
            {
                var leftIndex = new Random().Next(0, rightIndex);

                var rightCard = cards[leftIndex];

                cards[rightIndex] = cards[leftIndex];

                cards[leftIndex] = rightCard;

            }

            foreach (var all in cards)

            {
                Console.WriteLine($"{all}");
            }


        }
    }
}
