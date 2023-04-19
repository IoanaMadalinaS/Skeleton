using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        public bool Active { get; set; }
        public DateTime ContractEndDate { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string SupplierName { get; set; }
        public int SupplierID { get; set; }

        public bool Find(int supplierID)
        {
            throw new NotImplementedException();
        }

        public string Valid(string supplierName, string phoneNumber, string email, string address, string contractEndDate)
        {
            throw new NotImplementedException();
        }
    }
}