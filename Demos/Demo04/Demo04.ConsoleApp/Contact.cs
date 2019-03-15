using System;
using System.Collections.Generic;
using System.Text;

namespace Demo04.ConsoleApp
{
    
    public class Contact
    {
        //info
        //private string _name;
        //public string Name {
        //    get { return _name; }
        //    set { _name = value; }
        //}

        public string Name { get; set; }

        //a phone number should never be longer than 255 letters
        private string _phoneNumber;
        //actions

        //string pn = mario.GetPhoneNumber()
        public string GetPhoneNumber() {
            return _phoneNumber;
        }

        //mario.SetPhoneNumber("2346572348657348657346573486537486378637865734865734653785683")
        public void SetPhoneNumber(string phoneNumber)
        {
            if (phoneNumber.Length > 255) {
                phoneNumber = phoneNumber.Substring(0, 255);
            }
            _phoneNumber = phoneNumber;
        }

        //string pn = mario.PhoneNumber //get
        //mario.PhoneNumber = "2346572348657348657346573486537486378637865734865734653785683" //set


        public string PhoneNumber //property
        {
            get
            {
                return _phoneNumber;
            }
            set { //value
                if (value.Length > 255)
                {
                    value = value.Substring(0, 255);
                }
                _phoneNumber = value;
            }
        }

    }
}
