using System;
using NUnit.Framework;

namespace CinemaApp.Tests
{
    [TestFixture]
    public class Adult_After_5_Test
    {

        //Adult_After_5(int pr_quantity, string pr_person, string pr_day, decimal pr_time)
        [Test]
        public void One_Adult_After_5_Return_Initial_Value()
        //Arrange test objects
        {
            //new instance
            var tic = new TicketPriceController();
            //Instance variables ~ act
            decimal price = tic.Adult_After_5(1, "adult", "monday", 6);
            //Assert correct ticket price
            Assert.That(price, Is.EqualTo(17.50));
        }

        //Test multiplicity pr_quantity
        [Test]
        public void Two_Adult_After_5_Return_Correct_Value()
        { //Arrange test objects
            //new instance
            var tics = new TicketPriceController();
            //Instance variables ~ act
            decimal price = tics.Adult_After_5(2, "adult", "monday", 6);
            //Assert correct ticket price
            Assert.IsNotNull(price);
            Assert.That(price, Is.EqualTo(35.00));
        }

        //Test half time pr_time
        [Test]
        public void Adult_After_5_HalfPast_Return_Correct_Price()
        {
            var tic = new TicketPriceController();
            decimal price = tic.Adult_After_5(1, "adult", "tuesday", 630);
            Assert.That(price, Is.EqualTo(17.50));
        } //Failed outcome -1

        //Test discount application pr_day
        [Test]
        public void Adult_After_5__On_Tuesday_Return_False()
        {
            var tic = new TicketPriceController();
            decimal price = tic.Adult_After_5(1, "adult", "tuesday", 6);
            Assert.That(price, Is.EqualTo(-1));
        }

        //Test pr_person input
        [Test]
        public void Incorrect_Person_Input_Return_False()
        {
            var tic = new TicketPriceController();
            decimal price = tic.Adult_After_5(1, "child", "tuesday", 330);
            Assert.That(price, Is.EqualTo(-1));
        }

        //Test Lower boundary pr_quantity
        [Test]
        public void Insufficient_Quantity_Return_False()
        {
            var tic = new TicketPriceController();
            decimal price = tic.Adult_After_5(0, "adult", "monday", 6);
            Assert.That(price, Is.EqualTo(-1));
        }

        //Test Upper boundary pr_quantity
        [Test]
        public void Excessive_Quantity_Return_False()
        {
            var tic = new TicketPriceController();
            decimal price = tic.Adult_After_5(99, "adult", "monday", 6);
            Assert.That(price, Is.EqualTo(-1));
        }
    }
}
