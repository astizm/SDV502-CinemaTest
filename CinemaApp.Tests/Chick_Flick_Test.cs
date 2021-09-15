using System;
using NUnit.Framework;

namespace CinemaApp.Tests
{[TestFixture]
    class Chick_Flick_Test      //Chick_Flick_Thursday(int pr_quantity, string pr_person, string pr_day)  expected result - 21.5
    {   
        //Test Baseline
        [Test]
        public void Return_Expected_Result()
        {
            var tic = new TicketPriceController();
            var price = tic.Chick_Flick_Thursday(1, "adult", "thursday");
            Assert.That(price, Is.EqualTo(21.5));
        }

        //Test multiplicity pr_quantity
        [Test]
        public void Return_Expected_Result_Multiple_Tickets()
        {
            var tic = new TicketPriceController();
            var price = tic.Chick_Flick_Thursday(2, "adult", "thursday");
            Assert.That(price, Is.EqualTo(43.0));
        }

        //Test invalid input pr_day
        [Test]
        public void Return_False_Value_Incorrect_Day_Input()
        {
            var tic = new TicketPriceController();
            var price = tic.Chick_Flick_Thursday(1, "adult", "tuesday");
            Assert.That(price, Is.EqualTo(-1));
        }

        //Test invalid input pr_person
        [Test]
        public void Return_False_Value_Incorrect_Person_Input()
        {
            var tic = new TicketPriceController();
            var price = tic.Chick_Flick_Thursday(1, "child", "thursday");
            Assert.That(price, Is.EqualTo(-1));
        }

        //Test lower boundary pr_quantity
        [Test]
        public void Return_False_Value_Insufficient_Ticket_Quantity()
        {
            var tic = new TicketPriceController();
            var price = tic.Chick_Flick_Thursday(0, "adult", "thursday");
            Assert.That(price, Is.EqualTo(-1));
        }
    }
}
