using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10.Core
{
    public class ListOfCards
    {
        private Card[] _cards = new Card[50];
        public int Count { get; private set; }
        public Card Add(Card card)
        {
            _cards[Count++] = card;
            return card;
        }

        //indexer
        public Card this[int index]
        {
            //get
            //Card cc = list[3];
            get {
                if (index >= Count) {
                    throw new IndexOutOfRangeException();
                }
                return _cards[index];
            }
            //set
            //list[i] = new GoldCard(....);
            //set { _cards[index] = value; }
        }
    }
}
