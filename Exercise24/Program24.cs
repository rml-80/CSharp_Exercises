//Complete

using System;
using System.Collections;
using System.Collections.Generic;

namespace Exercise24
{
    class Program24
    {
        public static int[] createDeck()
        {
            int[] deck = new int[52];
            int card = 1;
            int slot = 0;

            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    deck[slot] = card;
                    slot++;
                }
                card++;
            }

            return deck;
        }

        static void ShuffleCards(ref int[] deck)
        {
            for (int t = 0; t < deck.Length; t++)
            {
                Random rnd = new Random();

                int tmp = deck[t];
                int r = rnd.Next(t, deck.Length);
                deck[t] = deck[r];
                deck[r] = tmp;
            }

            foreach (var item in deck)
            {
                Console.Write(item + ",");
            }
           
        }

        static int DrawCard(ref int[] deck)
        {
            Random rnd = new Random();
            var i = rnd.Next(0, deck.Length);
            var card = deck[i];

            return card;
        }

        static int drawArray(ref int[] cardDraw, ref int newCard)
        {

            Array.Resize(ref cardDraw, cardDraw.Length + 1);
            cardDraw[cardDraw.Length - 1] = newCard;
            Console.WriteLine("Length of array: " + cardDraw.Length);
            foreach (var item in cardDraw)
            {
                Console.Write(item + ",");
            }
            return newCard;
        }

        static void Main(string[] args)
        {
            int[] deck = createDeck();
            int[] cardDraw = new int[0];
            int index = 0;

            foreach (var item in deck)
            {
                Console.Write(item + ",");
            }

            Console.WriteLine("\n");

            ShuffleCards(ref deck);

            Console.WriteLine("\n");

            ArrayList deckList = new ArrayList();
            deckList.AddRange(deck);

            while (true)
            {
                var newCard = DrawCard(ref deck);
                Console.WriteLine($"Card picked {newCard}");

                drawArray(ref cardDraw, ref newCard);
                
                index = Array.IndexOf(deck, newCard);
                Console.WriteLine("\n" + index);

                deckList.RemoveAt(index);
                Console.WriteLine("List count: " + deckList.Count);

                foreach (var item in deckList)
                {
                    Console.Write(item + ",");
                }

                Console.WriteLine("\n");
                Console.Write("want to continue? y/n ");
                var ans = Console.ReadLine();
                
                if (ans == "n")
                {
                    break;
                }
            }
        }
    }
}
