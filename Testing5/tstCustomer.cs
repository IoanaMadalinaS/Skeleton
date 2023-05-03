using ClassLibrary;
using DocuSign.eSign.Model;
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
        public void DateODBirthPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //asign the data to the property
            AnCustomer.Date_of_Birth = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Date_of_Birth, TestData);
        }

        [TestMethod]
        public void Customer_FirstnameOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String TestData = "Abena";
            AnCustomer.Firstname = TestData;
            Assert.AreEqual(AnCustomer.Firstname, TestData);
        }

        [TestMethod]
        public void Customer_LastnameOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String TestData = "Smith";
            AnCustomer.Lastname = TestData;
            Assert.AreEqual(AnCustomer.Lastname, TestData);
        }

        [TestMethod]
        public void Date_of_BirthOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            DateTime TestData = new DateTime(01 / 05 / 2002);
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
            string TestData = "LE2 6FP";
            AnCustomer.Address = TestData;
            Assert.AreEqual(AnCustomer.Address, TestData);
        }



        [TestMethod]
        
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to use with the method
            Int32 Customer_ID = 1;
            //invoke the method
            Boolean found = AnCustomer.Find(Customer_ID);
            //test to see that the result is correct
            Assert.IsTrue(found);
        }


        [TestMethod]
        public void TestCustomer_IDFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Customer_ID = 1;
            //invoke the method
            Found = AnCustomer.Find(Customer_ID);
            //check the address no
            if (AnCustomer.Customer_ID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFirstnamefound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Customer_ID = 1;
            //invoke the method
            Found = AnCustomer.Find(Customer_ID);
            //check the property
            if (AnCustomer.Firstname != "Vivian")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastnameFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Customer_ID = 1;
            //invoke the method
            Found = AnCustomer.Find(Customer_ID);
            //check the property
            if (AnCustomer.Lastname != "Smith")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDate_of_BirthFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Customer_ID = 1;
            //invoke the method
            Found = AnCustomer.Find(Customer_ID);
            //check the property
            if (AnCustomer.Date_of_Birth != Convert.ToDateTime("01/03/2000"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }




        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Customer_ID = 1;
            //invoke the method
            Found = AnCustomer.Find(Customer_ID);
            //check the property
            if (AnCustomer.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerProperties()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to use with the method
            Int32 Customer_ID = 1;
            //invoke the method
            AnCustomer.Find(Customer_ID);
            //test to see that the properties are correct
            Assert.AreEqual(AnCustomer.Customer_ID, Customer_ID);
            Assert.AreEqual(AnCustomer.Firstname, "Vivian");
            Assert.AreEqual(AnCustomer.Lastname, "Smith");
            Assert.AreEqual(AnCustomer.Date_of_Birth, new DateTime(2000, 3, 1));
            Assert.IsTrue(AnCustomer.Active);
        }
    }
    [TestMethod]
    public void ValidMethodOK()
    {
        //create an instance of the class we want to create
        clsCustomer AnCustomer = new clsCustomer();
        //create some test data to use with the method
        String FirstName = "John";
        String Lastname = "Doe";
        DateTime Date_Of_Birth = new DateTime(01, 04, 02);
        String Email = "johndoe@example.com";
        String Address = "123 Main St.";
        //invoke the method
        String error = AnCustomer.Valid(FirstName, Lastname, Date_Of_Birth, Email, Address);
        //test to see that the result is correct
        Assert.AreEqual(error, "");
    }

    [TestMethod]
    public void Customer_IDMin()
    {
        clsCustomer AnCustomer = new clsCustomer();
        String Error = "";
        string Customer_ID = "a";
        Error = AnCustomer.Valid(Customer_ID, Lastname, Date_of_Birth, Email, Postcode);
        Assert.AreEqual(Error, "");
    }

    [TestMethod]
    public void Customer_IDMinPlusOne()
    {
        clsCustomer AnCustomer = new clsCustomer();
        String Error = "";
        string Customer_ID = "aa";
        Error = AnCustomer.Valid(Customer_ID, Lastname, Date_of_Birth, Email, Postcode);
        Assert.AreEqual(Error, "");
    }

    [TestMethod]
    public void Customer_IDMaxLessOne()
    {
        clsCustomer AnCustomer = new clsCustomer();
        String Error = "";
        string Customer_ID = "aaaaa";
        Error = AnCustomer.Valid(Customer_ID, Lastname, Date_of_Birth, Email, Address);
        Assert.AreEqual(Error, "");
    }

    [TestMethod]
    public void Customer_IDNoMax()
    {
        clsCustomer AnCustomer = new clsCustomer();
        String Error = "";
        string Customer_ID = "aaaaaa";
        Error = AnCustomer.Valid(Customer_ID, Lastname, Date_of_Birth, Email, Address);
        Assert.AreEqual(Error, "");
    }

    [TestMethod]
    public void Customer_IDNoMid()
    {
        clsCustomer AnCustomer = new clsCustomer();
        String Error = "";
        string Customer_ID = "aaa";
        Error = AnCustomer.Valid(Customer_ID, Lastname, Date_of_Birth, Email, Address);
        Assert.AreEqual(Error, "");
    }

    [TestMethod]
    public void FirstnameMin()
    {
        clsCustomer AnCustomer = new clsCustomer();
        String Error = "";
        string Firstname = "a";
        Error = AnCustomer.Valid(Firstname, Lastname, Date_of_Birth, Email, Postcode);
        Assert.AreEqual(Error, "");
    }

    [TestMethod]
    public void FirstnameMinPlusOne()
    {
        clsCustomer AnCustomer = new clsCustomer();
        String Error = "";
        string Firstname = "aa";
        Error = AnCustomer.Valid(Firstname, Lastname, Date_of_Birth, Email, Postcode);
        Assert.AreEqual(Error, "");
    }

    [TestMethod]
    public void FirstnameMaxLessOne()
    {
        clsCustomer AnCustomer = new clsCustomer();
        String Error = "";
        string Firstname = "aaaaa";
        Error = AnCustomer.Valid(Firstname, Lastname, Date_of_Birth, Email, Address);
        Assert.AreEqual(Error, "");
    }

    [TestMethod]
    public void FirstnameNoMax()
    {
        clsCustomer AnCustomer = new clsCustomer();
        String Error = "";
        string Firstname = "aaaaaa";
        Error = AnCustomer.Valid(Firstname, Lastname, Date_of_Birth, Email, Address);
        Assert.AreEqual(Error, "");
    }

    [TestMethod]
    public void FirstnameNoMid()
    {
        clsCustomer AnCustomer = new clsCustomer();
        String Error = "";
        string Firstname = "aaa";
        Error = AnCustomer.Valid(Firstname, Lastname, Date_of_Birth, Email, Address);
        Assert.AreEqual(Error, "");
    }

    [TestMethod]
    public void LastnameMin()
    {
        clsCustomer AnCustomer = new clsCustomer();
        String Error = "";
        string Lastname = "a";
        Error = AnCustomer.Valid(Firstname, Lastname, Date_of_Birth, Email, Postcode);
        Assert.AreEqual(Error, "");
    }

    [TestMethod]
    public void LastnameMinPlusOne()
    {
        clsCustomer AnCustomer = new clsCustomer();
        String Error = "";
        string Lastname = "aa";
        Error = AnCustomer.Valid(Firstname, Lastname, Date_of_Birth, Email, Postcode);
        Assert.AreEqual(Error, "");
    }



}


