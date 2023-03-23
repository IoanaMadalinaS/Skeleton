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
        [TestMethod]
        public void ItemNo()
        {
            clsStock AnOrders = new clsStock();

            Int32 TestData = 1;

            AnOrders.ItemN = TestData;

            Assert.AreEqual(AnOrders.ItemN, TestData);


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
            bool TestData = true;
            Item.ItemAvaliable = TestData;
            Assert.AreEqual(Item.ItemAvaliable, TestData);
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
