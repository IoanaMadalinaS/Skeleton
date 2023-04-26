using System;

namespace ClassLibrary
{
    public class clsOrders
    {
        public readonly string CostumerName;
        private string mPostCode;
        private int mOrderId;
        private string mCustomerName;
        private decimal mTotal;
        private string mDeliveryAddress;
        private DateTime mOrderDate;
        private bool mDeliveryStatus;
        public bool Active { get; set; }

        public string PostCode
        {
            get { return mPostCode; }
            set { mPostCode = value; }
        }

        public int OrderId
        {
            get { return mOrderId; }
            set { mOrderId = value; }
        }

        public string CustomerName
        {
            get { return mCustomerName; }
            set { mCustomerName = value; }
        }

        public string DeliveryAddress
        {
            get { return mDeliveryAddress; }
            set { mDeliveryAddress = value; }
        }

        public decimal Total
        {
            get { return mTotal; }
            set { mTotal = value; }
        }

        public DateTime OrderDate
        {
            get { return mOrderDate; }
            set { mOrderDate = value; }
        }

        public bool DeliveryStatus
        {
            get { return mDeliveryStatus; }
            set { mDeliveryStatus = value; }
        }


        public bool Find(int OrderID)
        {
            clsDataConnection BD = new clsDataConnection();


            BD.AddParameter("@OrderID", OrderId);

            BD.Execute("sproc_dboOrders_SelectAll");

            if (BD.Count == 1)
            {
                mPostCode =Convert.ToString(BD.DataTable.Rows[0]["@PostCode"]);
                mOrderId = Convert.ToInt32(BD.DataTable.Rows[0]["@OrderId"]);
                mCustomerName = Convert.ToString(BD.DataTable.Rows[0]["@CostumerName"]);
                mTotal = Convert.ToDecimal(BD.DataTable.Rows[0]["@Total"]);
                mDeliveryAddress = Convert.ToString(BD.DataTable.Rows[0]["@DeliveryAddress"]);
                mOrderDate = Convert.ToDateTime(BD.DataTable.Rows[0]["@OrderDate"]);
                mDeliveryStatus = Convert.ToBoolean(BD.DataTable.Rows[0]["@DeliveryStatus"]);

                return true;
            }

            else
            {
                return false;
            }

            /*//set the private data members to the test data value
            mPostCode = "XXX XXX";
            mOrderId = 21;
            mCustomerName = "Test";
            mTotal = 22.50m;
            mDeliveryAddress = "XXX XXX";
            mOrderDate = Convert.ToDateTime("29/08/2002");
            mDeliveryStatus = true;

            //always return true
            return true;*/
        }

    }
}