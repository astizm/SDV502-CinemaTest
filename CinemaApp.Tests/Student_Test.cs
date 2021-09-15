using System;
using NUnit.Framework;


namespace CinemaApp.Tests
{
    [TestFixture]
    class Student_Test //Student(int pr_quantity, string pr_person) bl expected Result = 14


    {   //Test baseline
        [Test]
        public void Return_Initial_Value()
        {
            var tic = new TicketPriceController();
            var price = tic.Student(1, "Student");
                Assert.That(price, Is.EqualTo(14.0));
        }

        //Test multiplicity
        [Test]
        public void Return_Correct_Value_Multiple_Tickets()
        {
            var tic = new TicketPriceController();
            var price = tic.Student(2, "Student");
            Assert.That(price, Is.EqualTo(28.0));
        }

        //Test incorrect Str value pr_person
        [Test]
        public void Return_False_Value_For_Incorrect_Person()
        {
            var tic = new TicketPriceController();
            var price = tic.Student(1, "adult");
            Assert.That(price, Is.EqualTo(-1));
        }
       
        //Test lower boundary
        [Test]
        public void Return_False_Value_Insufficient_Quantity()
        {
            var tic = new TicketPriceController();
            var price = tic.Student(0, "Student");
            Assert.That(price, Is.EqualTo(-1));
        }

        //Test upper boundary
        [Test]
        public void Return_False_Value_Exceeded_Available_Ticket_Quantity()
        {
            var tic = new TicketPriceController();
            var price = tic.Student(99, "Student");
            Assert.That(price, Is.EqualTo(-1));
        } //Failed outcome - 1386
    }
}
