using System;
using DocuSign.eSign.Model;

namespace Testing5
{
    internal class clsCustomer
    {
        public int Customer_ID { get; internal set; }
        public bool Active { get; internal set; }
        public DateTime Date_of_Birth { get; internal set; }
        public string Firstname { get; internal set; }
        public string Lastname { get; internal set; }
        public string Email { get; internal set; }
        public string Address { get; internal set; }

        internal bool Find(int customer_ID)
        {
            throw new NotImplementedException();
        }

        internal string Valid(string firstName, string lastname, DateTime date_Of_Birth, string email, string address)
        {
            throw new NotImplementedException();
        }

        internal string Valid(string customer_ID, object lastname, object date_of_Birth, Email email, object postcode)
        {
            throw new NotImplementedException();
        }

        internal string Valid(object firstname, string lastname, object date_of_Birth, Email email, object postcode)
        {
            throw new NotImplementedException();
        }
    }
}