using System;
using ConsoleApp.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Taking_Order()
        {
            Cashier cashier = new Cashier();
            cashier.GetOrder();
        }
    }
}
