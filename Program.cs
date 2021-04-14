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

            var numberOfCardsInList = cards.Count * 4;

            var aceCard = cards[0];

            var twoCard = cards[1];

            var threeCard = cards[2];

            var fourCard = cards[3];

            var fiveCard = cards[4];

            var sixCard = cards[5];

            var sevenCard = cards[6];

            var eightCard = cards[7];

            var nineCard = cards[8];

            var tenCard = cards[9];

            var jackCard = cards[10];

            var queenCard = cards[11];

            var kingCard = cards[12];


            Console.WriteLine($"There are {numberOfCardsInList} cards in my deck!");









        }
    }
}
