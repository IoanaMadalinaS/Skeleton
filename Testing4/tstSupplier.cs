using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstSupplier
    {
        string SupplierName = "Armstrong Ltd";
        string PhoneNumber = "01614960390";
        string Email = "contact@amstrongltd.com";
        string Address = "123A Edrich Road Boston United Kingdom B12 VBM";
        string ContractEndDate = DateTime.Now.Date.ToString();

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //test to see that it exists
            Assert.IsNotNull(AnSupplier);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data
            Boolean TestData = true;
            //assign the data to the property
            AnSupplier.Active = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnSupplier.Active, TestData);
        }

        [TestMethod]
        public void ContractEndDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnSupplier.ContractEndDate = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnSupplier.ContractEndDate, TestData);
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            string TestData = "1A BostonRoad Leicester LE15AB";
            //assign the data to the property
            AnSupplier.Address = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnSupplier.Address, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            string TestData = "contact@supplier.com";
            //assign the data to the property
            AnSupplier.Email = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnSupplier.Email, TestData);
        }

        [TestMethod]
        public void PhoneNumberPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            string TestData = "0116234675";
            //assign the data to the property
            AnSupplier.PhoneNumber = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnSupplier.PhoneNumber, TestData);
        }

        [TestMethod]
        public void SupplierNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            string TestData = "Germanos Ltd";
            //assign the data to the property
            AnSupplier.SupplierName = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnSupplier.SupplierName, TestData);
        }

        [TestMethod]
        public void SupplierIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            int TestData = 1;
            //assign the data to the property
            AnSupplier.SupplierID = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnSupplier.SupplierID, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method 
            Int32 SupplierID = 1;
            //invoke the method
            Found = AnSupplier.Find(SupplierID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestSupplierIDFound()
        {
            //created an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 SupplierID = 1;
            bool
            //invoke the method
            Found = AnSupplier.Find(SupplierID);
            //check the suppler id
            if (AnSupplier.SupplierID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestContractEndDateFound()
        {
            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 SupplierID = 1;
            //invoke the method 
            Found = AnSupplier.Find(SupplierID);
            //check the property 
            if (AnSupplier.ContractEndDate != Convert.ToDateTime("2030-08-25"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierNameFound()
        {
            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 SupplierID = 1;
            //invoke the method 
            Found = AnSupplier.Find(SupplierID);
            //check the property 
            if (AnSupplier.SupplierName != "Armstrong Ltd")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneNumberFound()
        {
            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 SupplierID = 1;
            //invoke the method 
            Found = AnSupplier.Find(SupplierID);
            //check the property 
            if (AnSupplier.PhoneNumber != "01614960390")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 SupplierID = 1;
            //invoke the method 
            Found = AnSupplier.Find(SupplierID);
            //check the property 
            if (AnSupplier.Email != "contact@amstrongltd.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 SupplierID = 1;
            //invoke the method 
            Found = AnSupplier.Find(SupplierID);
            //check the property 
            if (AnSupplier.Address != "123A Edrich Road Boston United Kingdom B12 VBM")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 SupplierID = 1;
            //invoke the method 
            Found = AnSupplier.Find(SupplierID);
            //check the property 
            if (AnSupplier.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //An instance of the class 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, PhoneNumber, Email, Address, ContractEndDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMinLessOne()
        {
            //an instance of the class
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //some test data to pass to the method 
            string SupplierName = ""; //this should trigger an error
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, PhoneNumber, Email, Address, ContractEndDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMin()
        {
            //an instance of the class
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //some test data to pass to the method 
            string SupplierName = "a"; //this should be ok
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, PhoneNumber, Email, Address, ContractEndDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMinPlusOne()
        {
            //an instance of the class
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //some test data to pass to the method 
            string SupplierName = "aa"; //this should be ok
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, PhoneNumber, Email, Address, ContractEndDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMaxLessOne()
        {
            //an instance of the class
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //some test data to pass to the method 
            string SupplierName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, PhoneNumber, Email, Address, ContractEndDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMax()
        {
            //an instance of the class
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //some test data to pass to the method 
            string SupplierName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, PhoneNumber, Email, Address, ContractEndDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMid()
        {
            //an instance of the class
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //some test data to pass to the method 
            string SupplierName = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, PhoneNumber, Email, Address, ContractEndDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMaxPlusOne()
        {
            //an instance of the class
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //some test data to pass to the method 
            string SupplierName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fail
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, PhoneNumber, Email, Address, ContractEndDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameExtremeMax()
        {
            //an instance of the class
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //some test data to pass to the method 
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, PhoneNumber, Email, Address, ContractEndDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ContractEndDateExtremeMin()
        {
            //an instance of the class
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less than 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string ContractEndDate = TestDate.ToString();
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, PhoneNumber, Email, Address, ContractEndDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ContractEndDateMinLessOne()
        {
            //an instance of the class
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less than 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string ContractEndDate = TestDate.ToString();
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, PhoneNumber, Email, Address, ContractEndDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ContractEndDateMin()
        {
            //an instance of the class
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string ContractEndDate = TestDate.ToString();
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, PhoneNumber, Email, Address, ContractEndDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ContractEndDateMinPlusOne()
        {
            //an instance of the class
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //a variable to store the test date data
            DateTime TestDate;
            //the date to todays date
            TestDate = DateTime.Now.Date;
            //the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string ContractEndDate = TestDate.ToString();
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, PhoneNumber, Email, Address, ContractEndDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ContractEndDateMaxMinusOne()
        {
            //an instance of the class
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //a variable to store the test date data
            DateTime TestDate;
            //the date to todays date
            TestDate = DateTime.Now.Date;
            //the date to whatever the date is minus 99 years
            TestDate = TestDate.AddYears(-99);
            //convert the date variable to a string variable
            string ContractEndDate = TestDate.ToString();
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, PhoneNumber, Email, Address, ContractEndDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ContractEndDateMax()
        {
            //an instance of the class
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //a variable to store the test date data
            DateTime TestDate;
            //the date to todays date
            TestDate = DateTime.Now.Date;
            //the date to whatever the date is 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string ContractEndDate = TestDate.ToString();
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, PhoneNumber, Email, Address, ContractEndDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ContractEndDateMaxPlusOne()
        {
            //an instance of the class
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //a variable to store the test date data
            DateTime TestDate;
            //the date to todays date
            TestDate = DateTime.Now.Date;
            //the date to whatever the date is 101 years
            TestDate = TestDate.AddYears(101);
            //convert the date variable to a string variable
            string ContractEndDate = TestDate.ToString();
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, PhoneNumber, Email, Address, ContractEndDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ContractEndDateMid()
        {
            //an instance of the class
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //a variable to store the test date data
            DateTime TestDate;
            //the date to todays date
            TestDate = DateTime.Now.Date;
            //the date to whatever the date is 50 years
            TestDate = TestDate.AddYears(50);
            //convert the date variable to a string variable
            string ContractEndDate = TestDate.ToString();
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, PhoneNumber, Email, Address, ContractEndDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ContractEndDateInvalidData()
        {
            //an instance of the class 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //ContractEndDate to a non date value
            string ContractEndDate = "this is not a date!";
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, PhoneNumber, Email, Address, ContractEndDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PhoneNumberMinLessOne()
        {
            //an instance of the class 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PhoneNumber = "";
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, PhoneNumber, Email, Address, ContractEndDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PhoneNumberMin()
        {
            //an instance of the class 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PhoneNumber = "1";
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, PhoneNumber, Email, Address, ContractEndDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PhoneNumberMinPlusOne()
        {
            //an instance of the class 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PhoneNumber = "12";
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, PhoneNumber, Email, Address, ContractEndDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PhoneNumberMaxLessOne()
        {
            //an instance of the class 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PhoneNumber = "1234567890123456789012345678901234567890123456789";
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, PhoneNumber, Email, Address, ContractEndDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PhoneNumberMax()
        {
            //an instance of the class 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PhoneNumber = "12345678901234567890123456789012345678901234567890";
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, PhoneNumber, Email, Address, ContractEndDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PhoneNumberMaxPlusOne()
        {
            //an instance of the class 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PhoneNumber = "123456789012345678901234567890123456789012345678901";
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, PhoneNumber, Email, Address, ContractEndDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PhoneNumberMid()
        {
            //an instance of the class 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PhoneNumber = "1234567890123456789012345";
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, PhoneNumber, Email, Address, ContractEndDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void EmailMinLessOne()
        {
            //an instance of the class 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Email = "";
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, PhoneNumber, Email, Address, ContractEndDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void EmailMin()
        {
            //an instance of the class 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "a";
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, PhoneNumber, Email, Address, ContractEndDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            //an instance of the class 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "aa";
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, PhoneNumber, Email, Address, ContractEndDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void AdddressMinLessOne()
        {
            //an instance of the class 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Address = "";
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, PhoneNumber, Email, Address, ContractEndDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void AdddressMin()
        {
            //an instance of the class 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Address = "a";
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, PhoneNumber, Email, Address, ContractEndDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void AdddressMinPlusOne()
        {
            //an instance of the class 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Address = "aa";
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, PhoneNumber, Email, Address, ContractEndDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

    }
}
