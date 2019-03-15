using System;
using System.Collections.Generic;
using System.Text;

namespace Demo10.ConsoleApp
{
    public class List<TypeOfTheItemOfMyList>
    {
        private TypeOfTheItemOfMyList[] _items = new TypeOfTheItemOfMyList[1000];
        public int Count { get; private set; }

        public void Add(TypeOfTheItemOfMyList item)
        {
            _items[Count++] = item;
        }

        public TypeOfTheItemOfMyList GetItemAt(int index)
        {
            return _items[index];
        }

        public TypeOfTheItemOfMyList this[int index]
        {
            get
            {
                return _items[index];
            }
        }
    }
}
