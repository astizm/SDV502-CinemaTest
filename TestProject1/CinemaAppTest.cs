using NUnit.Framework;

namespace CinemaApp.Test
{
    public class Adult_Before_5_Should
    /*Parameters Adult_Before_5(int pr_quantity, string pr_person, string pr_day, decimal pr_time)
     Init Price = $14.50*/
    {
        //Arrange
        [TestCase]
        public void return_Adult_Before_5_Price()
        {
            var tic = new TicketPriceController();
            
        }
        //Act
        Adult_Before_5(1,'adult', 'monday',3)
        //Assert
        
        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }

    internal class TicketPriceController
    {
        public TicketPriceController()
        {
        }
    }
}