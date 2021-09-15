using System;
using NUnit.Framework;

namespace CinemaApp.Tests
{[TestFixture]
    class Kids_Careers_Test //Kids_Careers(int pr_quantity, string pr_day, bool pr_holiday) Expected Result - 12.0
    {
        //Test baseline
        [Test]
        public void Return_Expected_Result()
        {
            var tic = new TicketPriceController();
            var price = tic.Kids_Careers(1, "wednesday", false);
            Assert.That(price, Is.EqualTo(12.0));
        }

        //Test multiplicity pr_quantity
        [Test]
        public void Return_Expected_Result_Multiple_Tickets()
        {
            var tic = new TicketPriceController();
            var price = tic.Kids_Careers(2, "wednesday", false);
            Assert.That(price, Is.EqualTo(24.0));
        }

        //Test invalid input pr_holiday
        [Test]
        public void Return_False_Value_Is_Holiday()
        {
            var tic = new TicketPriceController();
            var price = tic.Kids_Careers(1, "wednesday", true);
            Assert.That(price, Is.EqualTo(-1));
        }

        //Test invalid input pr_day
        [Test]
        public void Return_False_Value_Incorrect_Day()
        {
            var tic = new TicketPriceController();
            var price = tic.Kids_Careers(1, "tuesday", false);
            Assert.That(price, Is.EqualTo(-1));
        }

        //Test lower boundary pr_quantity
        [Test]
        public void Return_False_Value_Insufficient_Ticket_Quantity()
        {
            var tic = new TicketPriceController();
            var price = tic.Kids_Careers(0, "wednesday", false);
            Assert.That(price, Is.EqualTo(-1));
        }
    }
}
