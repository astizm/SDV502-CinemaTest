using System;
using NUnit.Framework;

namespace CinemaApp.Tests
{
    [TestFixture]
    class Adult_Tuesday_Test
    {
        //Test baseline
        [Test]
        public void Return_Initial_Value()
        {
            var tic = new TicketPriceController();
            decimal price = tic.Adult_Tuesday(1, "adult", "tuesday");
            Assert.That(price, Is.EqualTo(13.00));
        }

        //Test correct return value for multiplicity
        [Test]
        public void Return_Correct_Value_Multiple_Adults()
        {
            var tic = new TicketPriceController();
            decimal price = tic.Adult_Tuesday(2, "adult", "tuesday");
            Assert.That(price, Is.EqualTo(26.00));
        }

        //Test Correct return value for incorrect day pr_day
        [Test]
        public void Return_False_Value_Incorrect_Day()
        {
            var tic = new TicketPriceController();
            decimal price = tic.Adult_Tuesday(1, "adult", "wednesday");
            Assert.That(price, Is.EqualTo(-1));
        }

        //Test correct return value for incorrect person pr_person
        [Test]
        public void Return_False_Value_Incorrect_Person()
        {
            var tic = new TicketPriceController();
            decimal price = tic.Adult_Tuesday(1, "child", "tuesday");
            Assert.That(price, Is.EqualTo(-1));
        }

        //Test lower boundary
        [Test]
        public void Return_False_Value_Insufficient_Quantity()
        {
            var tic = new TicketPriceController();
            decimal price = tic.Adult_Tuesday(0, "adult", "tuesday");
            Assert.That(price, Is.EqualTo(-1));
        }

        //Test upper boundary
        [Test]
        public void Return_False_Value_Exceed_Available_Tickets()
        {
            var tic = new TicketPriceController();
            decimal price = tic.Adult_Tuesday(99, "adult", "tuesday");
            Assert.That(price, Is.EqualTo(-1));
        }
        //Fail - outcome 1287
    }
}
