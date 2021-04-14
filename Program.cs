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

            var deck = new List<string>();

            for (var d = 0; d < cards.Count; d++)
            {
                for (var b = 0; b < suits.Count; b++)
                {
                    var allCards = ($"{cards[d]} of {suits[b]}");
                    deck.Add(allCards);
                }

            }

            foreach (var all in deck)

            {
                Console.WriteLine($"{all}");
            }


            Console.WriteLine();


            var numberOfCards = deck.Count;

            for (var rightIndex = numberOfCards - 1; rightIndex >= 0; rightIndex--)
            {
                var leftIndex = new Random().Next(0, rightIndex);
                // Placeholder for rightcard
                var rightCard = deck[rightIndex];
                // Placeholder for leftcard
                var leftCard = deck[leftIndex];

                deck[leftIndex] = rightCard;
                deck[rightIndex] = leftCard;

            }

            foreach (var all in deck)

            {
                Console.WriteLine($"{all}");
            }

            Console.WriteLine();

            Console.WriteLine($"Want two random cards drawn..... voila! Here's {deck[0]} and {deck[1]}");

            Console.WriteLine();
        }
    }
}
