using System;
using NUnit.Framework;

namespace CinemaApp.Tests
{[TestFixture]
    public class Adult_Before_5_Test
    {
        //Adult_Before_5(int pr_quantity, string pr_person, string pr_day, decimal pr_time)
       
        //Test Initial Value Result
        [Test]
        public void One_Adult_Before_5_Return_Correct_Value()
        //Arrange test objects
        {
            //new instance
            var tic = new TicketPriceController();
            //Instance variables ~ act
            decimal price = tic.Adult_Before_5(1, "adult", "monday", 4);
            //Assert correct ticket price
            Assert.That(price, Is.EqualTo(14.50));
        }
        //Test multiplicity pr_quantity
        [Test]
        public void Two_Adult_Before_5_Return_Correct_Value()
        { //Arrange test objects
            //new instance
            var tics = new TicketPriceController();
            //Instance variables ~ act
            decimal price = tics.Adult_Before_5(2, "adult", "monday", 4);
            //Assert correct ticket price
            Assert.That(price, Is.EqualTo(29.00));
        }
        
        //Test half time application pr_time
        [Test]
        public void Adult_Before_5_HalfPast_Return_Correct_Price()
        {
            var tic = new TicketPriceController();
            decimal price = tic.Adult_Before_5(1, "adult", "tuesday", 1530);
            Assert.That(price, Is.EqualTo(14.50));
        }  //Failed outcome -1
        
        //Test time boundary pr_time
        [Test]
        public void Adult_After_5_Return_False()
        {
            var tic = new TicketPriceController();
            decimal price = tic.Adult_Before_5(1, "adult", "tuesday", 6);
            Assert.That(price, Is.EqualTo(-1));
        }

        //Test pr_person parameter
        [Test]
        public void Incorrect_Person_Input_Return_Correct_Value()
        {
            var tic = new TicketPriceController();
            decimal price = tic.Adult_Before_5(1, "child", "tuesday", 330);
            Assert.That(price, Is.EqualTo(-1));
        }

        //Test Lower Boundary pr_quantity
        [Test]
        public void Insufficient_Quantity_Before_5_Return_Correct_Value()
        //Arrange test objects
        {
            //new instance
            var tic = new TicketPriceController();
            //Instance variables ~ act
            decimal price = tic.Adult_Before_5(0, "adult", "monday", 4);
            //Assert correct ticket price
            Assert.That(price, Is.EqualTo(-1));
        }
        //Test Upper Boundary pr_quantity
        [Test]
        public void Excessive_Quantity_Before_5_Return_Correct_Value()
        //Arrange test objects
        {
            //new instance
            var tic = new TicketPriceController();
            //Instance variables ~ act
            decimal price = tic.Adult_Before_5(99, "adult", "monday", 4);
            //Assert correct ticket price
            Assert.That(price, Is.EqualTo(-1));
        }
        //Test Discount Type pr_day
        [Test]
        public void Incorrect_Discount_Applied_Return_Correct_Value()
        //Arrange test objects
        {
            //new instance
            var tic = new TicketPriceController();
            //Instance variables ~ act
            decimal price = tic.Adult_Before_5(1, "adult", "tuesday", 4);
            //Assert correct ticket price
            Assert.That(price, Is.EqualTo(-1));
        }
    }
}
