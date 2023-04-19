using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an nstance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exist
            Assert.IsNotNull(AnCustomer);
        }
        [TestMethod]
        public void ActivePropertyOK()
        {
            // create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnCustomer.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Active, TestData);

        }
        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //asign the data to the property
            AnCustomer.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.DateAdded, TestData);
        }

        [TestMethod]
        public void Customer_FirstnameOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String TestData = "Abena";
            AnCustomer.Customer_Firstname = TestData;
            Assert.AreEqual(AnCustomer.Customer_Firstname, TestData);
        }

        [TestMethod]
        public void Customer_LastnameOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String TestData = "Smith";
            AnCustomer.Customer_Lastname = TestData;
            Assert.AreEqual(AnCustomer.Customer_Lastname, TestData);
        }

        [TestMethod]
        public void Date_of_BirthOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            DateTime TestData = new DateTime(01/05/2002);
            AnCustomer.Date_of_Birth = TestData;
            Assert.AreEqual(AnCustomer.Date_of_Birth, TestData);
        }

        [TestMethod]
        public void EmailOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String TestData = "A.Smith@gmail.com";
            AnCustomer.Email = TestData;
            Assert.AreEqual(AnCustomer.Email, TestData);
        }
        [TestMethod]
        public void AddressOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string TestData = "LE1 7EE";
            AnCustomer.Address = TestData;
            Assert.AreEqual(AnCustomer.Address, TestData);
        }

    }
}
