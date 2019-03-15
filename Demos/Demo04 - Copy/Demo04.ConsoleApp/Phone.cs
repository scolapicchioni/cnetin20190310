using System;
using System.Collections.Generic;
using System.Text;

namespace Demo04.ConsoleApp
{
    public class Phone
    {
        public string Brand;
        public string Model;

        private Contact[] _contacts = new Contact[100];
        //private int _contactsCount; //field

        //public int ContactsCount //property
        //{
        //    get
        //    {
        //        return _contactsCount;
        //    }
        //}
        public int ContactsCount { get; private set; }


        //.AddContact(superMario);
        public void AddContact(Contact contact) {
            Contact newContact = new Contact() { Name = contact.Name, PhoneNumber = contact.PhoneNumber };
            _contacts[ContactsCount++] = newContact;
        }

        //.GetContactAt(i)
        public Contact GetContactAt(int index) {
            return _contacts[index];
        }

    }
}
