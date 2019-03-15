using Lab10.Core;
using System;

namespace Lab10.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Shop s = new Shop();
            //s.AddRegularCard("Mario", "Super Road", "NY", 100);
            //s.AddRegularCard("Peach", "Princesses Road", "Paris", 200);
            //s.AddGoldCard("Luigi", "Super Road", "NY",10, 100);
            //s.AddGoldCard("Wario", "Super Road", "NY", 30, 200);

            //printCards(s);

            //Card c = s.GetCardById(3);
            //c.Pay(10);
            //printCards(s);


            //ListOfCards list = new ListOfCards();
            //list.Add(new GoldCard("", "", "", 1));
            //list.Add(new GoldCard("", "", "", 1));
            //list.Add(new GoldCard("", "", "", 1));
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Card cc = list[i];
            //}


            for (int i = 0; i < 100000000000; i++)
            {
                new RegularCard("", "", "", i);
            }

            Console.ReadLine();
        }

        private static void printCards(Shop shop)
        {
            Console.WriteLine("*********************");
            for (int i = 0; i < shop.ListOfCards.Count; i++)
            {
                Console.WriteLine(shop.ListOfCards[i].AsString()); 
            }

            //foreach (Card item in shop.ListOfCards)
            //{
            //    Console.WriteLine(item.AsString());
            //}
        }
    }
}
