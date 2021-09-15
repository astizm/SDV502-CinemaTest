using System;
using NUnit.Framework;

namespace CinemaApp.Tests
{ [TestFixture]
    class Family_Pass_Test //Family_Pass(int pr_quantity_ticket, int pr_quantity_adult, int pr_quantity_child) - 46.00


    {   //Test baseline, 2 Adults, 2 Children
        [Test]
        public void Return_Expected_Result_2a2c()
        {
            var tic = new TicketPriceController();
            var price = tic.Family_Pass(1, 2, 2);
            Assert.That(price, Is.EqualTo(46.00));
        }

        //Test baseline, 1 Adult, 3 Children
        [Test]
        public void Return_Expected_Result_1a3c()
        {
            var tic = new TicketPriceController();
            var price = tic.Family_Pass(1, 1, 3);
            Assert.That(price, Is.EqualTo(46.00));
        }

        //Test multiplicity, 1 Adult, 3 Children
        [Test]
        public void Return_Expected_Result_Multiple_Tickets_1a3c()
        {
            var tic = new TicketPriceController();
            var price = tic.Family_Pass(2, 1, 3);
            Assert.That(price, Is.EqualTo(92.00));
        }

        //Test invalid input adult
        [Test]
        public void Return_False_Value_2a3c()
        {
            var tic = new TicketPriceController();
            var price = tic.Family_Pass(1, 2, 3);
            Assert.That(price, Is.EqualTo(-1));
        }

        //Test invalid input, 1 Adult, 4 Children
        [Test]
        public void Return_False_Value_1a3c()
        {
            var tic = new TicketPriceController();
            var price = tic.Family_Pass(1, 1, 4);
            Assert.That(price, Is.EqualTo(-1));
        }

    }
}
