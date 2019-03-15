using System;
using Xunit;

namespace Demo04.ConsoleApp.Tests
{
    public class TechSupportTests
    {
        [Fact]
        public void CopyShouldCopyTheContactsFromSourceToTargetPhone()
        {
            //arrange

            //create a contact
            Contact superMario = new Contact();
            //fill a contact with info
            superMario.Name = "SuperMario";
            superMario.PhoneNumber = "06123456789";

            //create a source phone
            Phone sourcePhone = new Phone();
            //fill the source phone with the contact
            //sourcePhone.Contacts[0] = superMario;
            sourcePhone.AddContact(superMario);

            //create a target phone
            Phone targetPhone = new Phone();

            //create a techsupport guy
            TechSupport theGuy = new TechSupport();

            //act
            theGuy.CopyContacts(sourcePhone, targetPhone);
            //ask the techtsupport guy to copy the contacts from the source to the target phone


            //assert
            
            //source and target contacts are the same collection
        }
    }
}
