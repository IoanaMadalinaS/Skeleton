﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsItemN Number = new clsItemN();
            Assert.IsNotNull(Number);
        }
    }
}
