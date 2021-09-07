using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace CinemaAppTest
{
    [TestClass]
    public class Adult_Before_5_Test
    {[TestMethod]
        public void IsTuesdayDiscountApplied()
        {
            var tic = new TicketPriceController();
            Assert.IsEqual(14.50);
        }
    }
}
