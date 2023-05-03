using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ClassLibrary
{
    public class ClsCustomer
    {
        private Int32 mCustomer_ID;
        public Int32 Customer_ID
        {
            get
            {
                return mCustomer_ID;
            }
            set
            {
                mCustomer_ID = value;
            }
        }

        private string mFirstname;

        public string Firstname
        {
            get
            {
                //return private data
                return mFirstname;
            }
            set
            {
                //set the private data
                mFirstname = value;
            }
        }

        private string mLastname;

        //public property for house no
        public string Lastname
        {
            get
            {
                //return private data
                return mLastname;
            }
            set
            {
                //set the private data
                mLastname = value;
            }
        }
        private String mAddress;
        //public property for the address number
        public String Address
        {
            get
            {
                //return the private data
                return mAddress;
            }

            set
            {
                //set the value of the private data member
                mAddress = value;
            }
        }


        private string mEmail;
        //public property for house no
        public string Email
        {
            get
            {
                //return private data
                return mEmail;
            }
            set
            {
                //set the private data
                mEmail = value;
            }
        }
        private Boolean mActive;

        //public property for active
        public bool Active
        {
            get
            {
                //return the private data
                return mActive;
            }
            set
            {
                //set the private data
                mActive = value;
            }
        }




        private DateTime mDate_Of_Birth;

        //public property for date added
        public DateTime Date_of_Birth
        {
            get
            {
                //return the private data
                return mDate_Of_Birth;
            }
            set
            {
                //set the private data
                mDate_Of_Birth = value;
            }
        }


        public bool Find(int Customer_ID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Customer_ID", Customer_ID);
            DB.Execute("sproc_tblCustomer_FilterByCustomer_ID");
            if (DB.Count == 1)
            {
                mCustomer_ID = Convert.ToInt32(DB.DataTable.Rows[0]["Customer_ID"]);
                mFirstname = Convert.ToString(DB.DataTable.Rows[0]["Firstname"]);
                mLastname = Convert.ToString(DB.DataTable.Rows[0]["Lastname"]);
                mDate_Of_Birth = Convert.ToDateTime(DB.DataTable.Rows[0]["Date_Of_Birth"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                //always return true
                return true;
            }
            else
            {
                return false;
            }
        }


        public string Valid(string Firstname, string Lastname, DateTime Date_Of_Birth, string Email, string Address)
        {
            string Error = "";
            if (Firstname.Length == 0)
            {
                Error += "The First name cannot be blank. ";
            }
            if (Firstname.Length < 2)
            {
                Error += "The First name must be more than one character. ";
            }
            if (Lastname.Length == 0)
            {
                Error += "The Lastname cannot be blank. ";
            }
            if (Lastname.Length < 2)
            {
                Error += "The Lastname must be more than one character. ";
            }
            if (Date_Of_Birth > DateTime.Now.Date)
            {
                Error += "The date cannot be in the future. ";
            }
            if (Date_Of_Birth == DateTime.MinValue)
            {
                Error += "The date of birth may not be blank. ";
            }
            if (Email.Length == 0)
            {
                Error += "The Email may not be blank. ";
            }
            if (Address.Length == 0)
            {
                Error += "The Address may not be blank. ";
            }
            if (Address.Length > 50)
            {
                Error += "The Address must be less than 50 characters. ";
            }
            return Error;
        }
    }
}




