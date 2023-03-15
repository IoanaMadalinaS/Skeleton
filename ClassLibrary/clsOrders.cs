using System;

namespace ClassLibrary
{
    public class clsOrders
    {
        

        public bool Active { get; set; }
       
        public int OrdersNo { get; set; }
      
        
        public string PostCode { get; set; }
       

        
        public int OrderId { get; set; }
        public string CostumerName { get; set; }
        public string DeliveryAddress { get; set; }
        public decimal Total { get; set; }
        public DateTime OrderDate { get; set; }
        public bool DeliveryStatus { get; set; }

        public bool Find(string costumerName)
        {
            return true ;
        }
    }
}