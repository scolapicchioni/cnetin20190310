using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10.Core
{
    public class GoldCard : Card
    {
        public GoldCard(string name, string address, string city, int customerId, int discount=10, decimal credit = 0) : base(name, address, city, customerId, credit) {
            Discount = discount;
        }
        private int _discount = 1;


        public override string AsString()
        {
            return $"{CustomerId} {CustomerName} {Address} {City} {Credit} {Discount}";
        }

        /// <summary>
        /// Discount offered to the customer. It must be between 1 and 30.
        /// </summary>
        public int Discount
        {
            get { return _discount; }
            set {
                if (value < 1 || value > 30)
                    throw new ArgumentOutOfRangeException("Discount", "Must be between 1 and 30");
                _discount = value;
            }
        }

        /// <summary>
        /// The amount is subtracted from his credit. 
        /// May have a negative balance and is offered a discount.
        /// </summary>
        /// <param name="amount">Amount to pay. May be greater than the Credit</param>
        /// <returns>True</returns>
        public override bool Pay(decimal amount)
        {
            amount = amount - (amount * _discount / 100);
            Credit -= amount;
            return true;
        }
    }
}
