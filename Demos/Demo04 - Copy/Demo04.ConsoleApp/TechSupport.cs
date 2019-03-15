using System;
using System.Collections.Generic;
using System.Text;

namespace Demo04.ConsoleApp
{
    public class TechSupport
    {
        public void CopyContacts(Phone source, Phone target) {
            //source.ContactsCount = 3;
            for (int i = 0; i < source.ContactsCount; i++)
            {
                target.AddContact(source.GetContactAt(i));
            }
            
        }
    }
}
