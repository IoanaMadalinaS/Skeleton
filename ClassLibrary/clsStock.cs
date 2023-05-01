using System;

namespace ClassLibrary
{
    public class clsStock
    {
        private Int32 mItemNo;
        public Int32 ItemNo
        {
            get { return mItemNo; }
            set { mItemNo = value; }
        }


        private DateTime mDateAdded;
        public DateTime DateAdded 
        {
            get { return mDateAdded; }
            set { mDateAdded = value; }
        }


        private Boolean mActive;
        public bool Active {

            get { return mActive; }
            set { mActive = value; }
        }


        private string mItemDesc;
        public string ItemDesc {
            get { return mItemDesc; }
            set { mItemDesc = value; }
        }

        private string mItemName;
        public string ItemName {
            get { return mItemName; }
            set { mItemName = value; }
        }


        private Boolean mAvaliable;
        public bool Avaliable {
            get { return mAvaliable; }
            set { mAvaliable = value; }
        }


        private decimal mPrice;
        public decimal Price {
            get { return mPrice; }
            set { mPrice = value; }
        }

        public bool Find(int ItemNo)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@ItemNo", ItemNo);

            DB.Execute("sproc_tblStock_FilterByItemNo");

            if (DB.Count == 1)
            {
                mItemNo = Convert.ToInt32(DB.DataTable.Rows[0]["ItemNo"]);
                mItemName = Convert.ToString(DB.DataTable.Rows[0]["ItemName"]);
                mItemDesc = Convert.ToString(DB.DataTable.Rows[0]["ItemDesc"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                mAvaliable = Convert.ToBoolean(DB.DataTable.Rows[0]["Avaliable"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);


                return true;
            }
            else
            {
                return false;
            }
        }


        public string Valid(string itemName, string itemDesc, string dateAdded, string price)
        {
            String Error = "";

            #region itemName

            //if itemName is blank
            if (itemName.Length == 0)
            {
                Error = Error + "The itemname may not be blank : ";
            }

            //if itemName is greator than 50
            if (itemName.Length > 50)
            {
                Error = Error + "The itemname must be less than 50 characters : ";
            }

            #endregion

            #region Dateadded
            try
            {
                DateTime DateTemp;
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateAdded);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch (Exception ex)
            {
                Error = Error + "The date was not a valid date : ";
            }


            #endregion

            #region itemDesc

            //if itemDesc is blank
            if (itemDesc.Length == 0)
            {
                Error = Error + "The item description may not be blank : ";
            }

            //if itemDesc is greator than 50
            if (itemDesc.Length > 50)
            {
                Error = Error + "The item description must be less than 50 characters : ";
            }

            #endregion

            #region price

            //if price is blank
            if (price.Length == 0)
            {
                Error = Error + "The price may not be blank : ";
            }

            decimal _tempvalue;
            if (Decimal.TryParse(price, out _tempvalue))
            {
                //do nothing
            }
            else
            {
                Error = Error + "The price was not a valid value : ";
            }

            #endregion


            return Error;
        }
    }
}