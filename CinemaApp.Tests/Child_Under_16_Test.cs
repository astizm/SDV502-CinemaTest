using System;
using NUnit.Framework;


namespace CinemaApp.Tests
{
    [TestFixture]
    class Child_Under_16_Test //Child_Under_16(int pr_quantity, string pr_person) bl expected Result = 12.00


    {   //Test baseline
        [Test]
        public void Return_Initial_Value()
        {
            var tic = new TicketPriceController();
            var price = tic.Child_Under_16(1, "Child");
                Assert.That(price, Is.EqualTo(12.0));
        }

        //Test multiplicity
        [Test]
        public void Return_Correct_Value_Multiple_Tickets()
        {
            var tic = new TicketPriceController();
            var price = tic.Child_Under_16(2, "Child");
            Assert.That(price, Is.EqualTo(24.0));
        }

        //Test incorrect Str value pr_person
        [Test]
        public void Return_False_Value_For_Incorrect_Person()
        {
            var tic = new TicketPriceController();
            var price = tic.Child_Under_16(1, "Senior");
            Assert.That(price, Is.EqualTo(-1));
        }
       
        //Test lower boundary
        [Test]
        public void Return_False_Value_Insufficient_Quantity()
        {
            var tic = new TicketPriceController();
            var price = tic.Child_Under_16(0, "Child");
            Assert.That(price, Is.EqualTo(-1));
        }

        //Test upper boundary
        [Test]
        public void Return_False_Value_Exceeded_Available_Ticket_Quantity()
        {
            var tic = new TicketPriceController();
            var price = tic.Child_Under_16(99, "Child");
            Assert.That(price, Is.EqualTo(-1));
        } //Failed ouput - 1188
    }
}
