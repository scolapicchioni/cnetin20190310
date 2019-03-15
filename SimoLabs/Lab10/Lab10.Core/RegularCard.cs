using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10.Core
{
    public class RegularCard : Card
    {
        public RegularCard(string name, string address, string city, int customerId, decimal credit = 0): base(name, address, city, customerId, credit)
        {
            //Console.WriteLine("building card " + customerId);
        }

        //~RegularCard() {
        //    Console.WriteLine($"/t/tDESTROYING CARD {CustomerId}");
        //}

        //public void Close() {
        //    GC.SuppressFinalize
        //}

        public override string AsString()
        {
            return $"{CustomerId} {CustomerName} {Address} {City} {Credit}";
        }

        /// <summary>
        /// The amount is subtracted from the credit. 
        /// Regular card may not have a negative balance 
        /// </summary>
        /// <param name="amount">The amount to pay. It may not be greater than the credit</param>
        /// <returns>True if payment succeeds</returns>
        public override bool Pay(decimal amount)
        {
            if (amount > Credit) {
                return false;
            }
            Credit -= amount;
            return true;
        }
        
    }
}
