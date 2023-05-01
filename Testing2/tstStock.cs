using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStock Item = new clsStock();
            Assert.IsNotNull(Item);
        }

        string ItemName = "Item_name";
        string ItemDesc = "Item_Desc";
        string DateAdded = "30/04/2023";
        string price = "2";


        [TestMethod]
        public void ValidRecord()
        {
            clsStock Item = new clsStock();

            String Error = "";

            Error = Item.Valid(ItemName, ItemDesc, DateAdded, price);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock objStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ItemName = ""; //this should trigger error
            //invoke the method
            Error = objStock.Valid(ItemName, ItemDesc, DateAdded, price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock objStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ItemName = "aa"; //this should be ok
            //invoke the method
            Error = objStock.Valid(ItemName, ItemDesc, DateAdded, price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock objStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ItemName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
                                      //invoke the method
            Error = objStock.Valid(ItemName, ItemDesc, DateAdded, price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ItemNameMax()
        {
            //create an instance of the class we want to create
            clsStock objStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ItemName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
                                       //invoke the method
            Error = objStock.Valid(ItemName, ItemDesc, DateAdded, price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMid()
        {
            //create an instance of the class we want to create
            clsStock objStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ItemName = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = objStock.Valid(ItemName, ItemDesc, DateAdded, price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock objStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ItemName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be an error
                                                                                   //invoke the method
            Error = objStock.Valid(ItemName, ItemDesc, DateAdded, price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsStock objStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = objStock.Valid(ItemName, ItemDesc, DateAdded, price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock objStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = objStock.Valid(ItemName, ItemDesc, DateAdded, price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsStock objStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = objStock.Valid(ItemName, ItemDesc, DateAdded, price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock objStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = objStock.Valid(ItemName, ItemDesc, DateAdded, price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock objStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = objStock.Valid(ItemName, ItemDesc, DateAdded, price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create
            clsStock objStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            
            //convert the date variable to a string variable

            //invoke the method
            Error = objStock.Valid(ItemName, ItemDesc, "Some data", price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemDescMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock objStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ItemDesc = ""; //this should trigger error
            //invoke the method
            Error = objStock.Valid(ItemName, ItemDesc, DateAdded, price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemDescMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock objStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ItemDesc = "aa"; //this should be ok
            //invoke the method
            Error = objStock.Valid(ItemName, ItemDesc, DateAdded, price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemDescMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock objStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ItemDesc = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
                                                                                  //invoke the method
            Error = objStock.Valid(ItemName, ItemDesc, DateAdded, price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ItemDescMax()
        {
            //create an instance of the class we want to create
            clsStock objStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ItemDesc = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
                                                                                   //invoke the method
            Error = objStock.Valid(ItemName, ItemDesc, DateAdded, price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemDescMid()
        {
            //create an instance of the class we want to create
            clsStock objStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ItemDesc = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = objStock.Valid(ItemName, ItemDesc, DateAdded, price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemDescMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock objStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ItemDesc = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be an error
                                                                                     //invoke the method
            Error = objStock.Valid(ItemName, ItemDesc, DateAdded, price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PriceMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock objStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string price = ""; //this should trigger error
            //invoke the method
            Error = objStock.Valid(ItemName, ItemDesc, DateAdded, price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceInvalidData()
        {
            //create an instance of the class we want to create
            clsStock objStock = new clsStock();
            //string variable to store any error message
            String Error = "";

            //convert the date variable to a string variable
            string price = "some data";

            //invoke the method
            Error = objStock.Valid(ItemName, ItemDesc, DateAdded, price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void Find()
        {
            int ItemNo = 21;

            clsStock Found = new clsStock();
            bool isFound = Found.Find(ItemNo);
            Assert.IsTrue(Found.ItemNo.Equals(ItemNo));

        }

        [TestMethod]
        public void TestItemNoFound()
        {
            clsStock Item = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 ItemNo = 21;

            Found = Item.Find(ItemNo);

            if (Item.ItemNo != 21)
            {
                OK = false;
            }

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            clsStock Item = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 ItemNo = 21;

            Found = Item.Find(ItemNo);

            if (Item.DateAdded != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestActiveFound()
        {
            clsStock Item = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 ItemNo = 21;

            Found = Item.Find(ItemNo);

            if (Item.Active != true)
            {
                OK = false;
            }

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestItemDescFound()
        {
            clsStock Item = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 ItemNo = 21;

            Found = Item.Find(ItemNo);

            if (Item.ItemDesc != "Item description")
            {
                OK = false;
            }

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestItemNameFound()
        {
            clsStock Item = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 ItemNo = 21;

            Found = Item.Find(ItemNo);

            if (Item.ItemName != "Item Name")
            {
                OK = false;
            }

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestAvaliableFound()
        {
            clsStock Item = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 ItemNo = 21;

            Found = Item.Find(ItemNo);

            if (Item.Avaliable != true)
            {
                OK = false;
            }

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestPriceFound()
        {
            clsStock Item = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 ItemNo = 21;

            Found = Item.Find(ItemNo);

            if (Item.Price != 2.3M)
            {
                OK = false;
            }

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void ItemNo()
        {
            clsStock AnOrders = new clsStock();

            Int32 TestData = 1;

            AnOrders.ItemNo = TestData;

            Assert.AreEqual(AnOrders.ItemNo, TestData);


        }

        [TestMethod]
        public void TestDateMethod()
        {
            clsStock Item = new clsStock();
            DateTime TestData = DateTime.Now.Date;
            Item.DateAdded = TestData;
            Assert.AreEqual(Item.DateAdded, TestData);
        }
        [TestMethod]
        public void ItemDescOK()
        {
            clsStock Item = new clsStock();
            string TestData = "";
            Item.ItemDesc = TestData;
            Assert.AreEqual(Item.ItemDesc, TestData);
        }
        [TestMethod]
        public void ItemNameOK()
        {
            clsStock Item = new clsStock();
            string TestData = "";
            Item.ItemName = TestData;
            Assert.AreEqual(Item.ItemName, TestData);
        }
        [TestMethod]
        public void ItemAvaliable()
        {
            clsStock Item = new clsStock();
            Boolean TestData = true;
            Item.Avaliable = TestData;
            Assert.AreEqual(Item.Avaliable, TestData);
        }
        [TestMethod]
        public void PriceOK()
        {
            clsStock Item = new clsStock();
            Decimal TestData = 2;
            Item.Price = TestData;
            Assert.AreEqual(Item.Price, TestData);


        }
    }
}
