using System;
using NUnit.Framework;


namespace CinemaApp.Tests
{
    [TestFixture]
    class Senior_Test //Senior(int pr_quantity, string pr_person) bl expected Result = 12.5


    {   //Test baseline
        [Test]
        public void Return_Initial_Value()
        {
            var tic = new TicketPriceController();
            var price = tic.Senior(1, "Senior");
                Assert.That(price, Is.EqualTo(12.5));
        }

        //Test multiplicity
        [Test]
        public void Return_Correct_Value_Multiple_Tickets()
        {
            var tic = new TicketPriceController();
            var price = tic.Senior(2, "Senior");
            Assert.That(price, Is.EqualTo(25.0));
        }

        //Test incorrect Str value pr_person
        [Test]
        public void Return_False_Value_For_Incorrect_Person()
        {
            var tic = new TicketPriceController();
            var price = tic.Senior(1, "adult");
            Assert.That(price, Is.EqualTo(-1));
        }
       
        //Test lower boundary
        [Test]
        public void Return_False_Value_Insufficient_Quantity()
        {
            var tic = new TicketPriceController();
            var price = tic.Senior(0, "Senior");
            Assert.That(price, Is.EqualTo(-1));
        }

        //Test upper boundary
        [Test]
        public void Return_False_Value_Exceeded_Available_Ticket_Quantity()
        {
            var tic = new TicketPriceController();
            var price = tic.Senior(99, "Senior");
            Assert.That(price, Is.EqualTo(-1));
        } //Failed outcome - 1237.5
    }
}
