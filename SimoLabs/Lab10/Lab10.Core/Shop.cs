using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10.Core
{
    public class Shop
    {
        public ListOfCards ListOfCards = new ListOfCards();
        
        public GoldCard AddGoldCard(string name, string address, string city, int discount = 10, decimal credit = 0)
        {
            return (GoldCard)ListOfCards.Add(new GoldCard(name, address, city, ListOfCards.Count + 1, discount, credit));
        }
        public RegularCard AddRegularCard(string name, string address, string city, decimal credit = 0)
        {
            return (RegularCard)ListOfCards.Add(new RegularCard(name, address, city, ListOfCards.Count + 1, credit));
        }

        
        public bool Pay(int cardId, int amount) {
            Card c = GetCardById(cardId);

            //if (c == null)
            //{
            //    return false;
            //}
            //else {
            //    return c.Pay(amount);
            //}

            return c?.Pay(amount) ?? false;
        }

        //public bool Pay2(int cardId, int amount) => GetCardById(cardId)?.Pay(amount) ?? false;
        

        public Card GetCardById(int id) {
            Card found = null;
            for (int i = 0; i < ListOfCards.Count; i++)
            {
                if (ListOfCards[i].CustomerId == id)
                {
                    found = ListOfCards[i];
                    break;
                }
            }
            return found;
        }
    }
}
