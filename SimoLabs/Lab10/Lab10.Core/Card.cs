using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10.Core
{
    public abstract class Card
    {
        //customer name, address, city, customer id and the credit
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int CustomerId { get; }
        public decimal Credit { get; set; }
        
        public Card(string name, string address, string city, int customerId, decimal credit=0)
        {
            CustomerName = name;
            Address = address;
            City = city;
            CustomerId = customerId;
            Credit = credit;
        }
        public abstract bool Pay(decimal amount);

        public abstract string AsString(); 
        
    }
}
