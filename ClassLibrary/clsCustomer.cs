﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ClassLibrary
{
    public class clsCustomer
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

        public DateTime Date_Of_Birth { get; set; }

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
                mDate_Of_Birth = Convert.ToDateTime("Date_Of_Birth");
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
    }


    public string Valid(string Customer_ID, string Firstname, string Lastname, string Date_Of_Birth, string Email, string Address, DateTime DateTemp)
    {
        string Error = "";

        // Remove the duplicate declaration of DateTemp
        // DateTime DateTemp;

        if (Firstname.Length == 0)
        {
            Error = "The First name cannot be blank: "; // Remove the duplicate assignment
        }
        if (Firstname.Length < 1) // Change the condition to check if length is less than 1
        {
            Error = Error + "The First name must be at least one character: "; // Fix the error message
        }

        // Use else if instead of if for this block to avoid unnecessary checks
        else if (Lastname.Length == 0)
        {
            Error = "The Lastname cannot be blank: ";
        }
        else if (Lastname.Length < 1) // Change the condition to check if length is less than 1
        {
            Error = Error + "The Lastname must be at least one character: "; // Fix the error message
        }

        // Use try-catch block to handle the exception when converting Date_Of_Birth to DateTime
        try
        {
            DateTemp = Convert.ToDateTime(Date_Of_Birth);
            if (DateTemp < DateTime.Now.Date)
            {
                Error = Error + "The date cannot be in the past : ";
            }
            else if (DateTemp > DateTime.Now.Date) // Use else if instead of another if for this block
            {
                Error = Error + "The date cannot be in the future : ";
            }
        }
        catch
        {
            Error = Error + "The date was not a valid date : ";
        }

        if (Date_Of_Birth.Length == 0)
        {
            Error = Error + "The date of birth may not be blank : "; // Fix the error message
        }
        else if (Date_Of_Birth.Length > 10) // Change the condition to check if length is greater than 10
        {
            Error += "The date of birth must be less than or equal to 10 characters : "; // Fix the error message
        }

        if (Email.Length == 0)
        {
            Error = Error + "The Email may not be blank: ";
        }

        if (Address.Length == 0) // Fix the condition to check if Address length is 0
        {
            Error = Error + "The Address may not be blank : ";
        }
        else if (Address.Length > 50)
        {
            Error = Error + "The Address must be less than or equal to 50 characters : "; // Fix the error message
        }

        return Error;
    }
}











