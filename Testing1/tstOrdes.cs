using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstOrdes
    {


        [TestMethod]
        public void InstaceOK()
        {
            //create an instance 
            clsOrders AnOrders = new clsOrders();

            // test to see that it exists
            Assert.IsNotNull(AnOrders);
        }




        [TestMethod]
        public void OrdersNoPropertyOK()
        {
            clsOrders AnOrders = new clsOrders();

            Int32 TestData = 1;

            AnOrders.OrderId = TestData;

            Assert.AreEqual(AnOrders.OrderId, TestData);

        }
        [TestMethod]
        public void CostumerNameOk()
        {
            clsOrders AnOrders = new clsOrders();

            String TestData = "Anna Brown";

            AnOrders.CostumerName = TestData;

            Assert.AreEqual(AnOrders.CostumerName, TestData);

        }
        [TestMethod]
        public void DeliveryAddressOK()
        {
            clsOrders AnOrders = new clsOrders();

            string TestData = "21b Overton road, LE5 0JB";

            AnOrders.DeliveryAddress = TestData;

            Assert.AreEqual(AnOrders.DeliveryAddress, TestData);
        }
        [TestMethod]
        public void PostCodePropertyOK()
        {
            clsOrders AnOrders = new clsOrders();
            string TestData = "LE1 4AB";

            AnOrders.PostCode = TestData;

            Assert.AreEqual(AnOrders.PostCode, TestData);
        }

        [TestMethod]
        public void OrderDateOk()
        {
            clsOrders AnOrders = new clsOrders();

            DateTime TestData = DateTime.Now.Date;

            AnOrders.OrderDate = TestData;

            Assert.AreEqual(AnOrders.OrderDate, TestData);
        }

        [TestMethod]
        public void PriceOK()
        {
            clsOrders AnOrders = new clsOrders();

            Decimal TestData = 2;

            AnOrders.Total = TestData;

            Assert.AreEqual(AnOrders.Total, TestData);


        }

        [TestMethod]
        public void ActiveOrdersOK()
        {
            clsOrders AnOrders = new clsOrders();

            Boolean TestData = true;

            AnOrders.DeliveryStatus = TestData;

            Assert.AreEqual(AnOrders.DeliveryStatus, TestData);
        }

       /* [TestMethod]
       public void FindMethodOK()
        {

            clsOrders AnOrders = new clsOrders;

            Boolean Found = false;

            String costumerName = "Anna";

            Found = AnOrders.Find(costumerName);

            Assert.IsTrue(Found);

         }*/

    }
}











