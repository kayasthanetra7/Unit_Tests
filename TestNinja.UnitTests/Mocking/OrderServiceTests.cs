using NUnit.Framework;
using TestNinja.Mocking;
using Moq;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class OrderServiceTests
    {
        [Test]
        public void PlaceOrder_WhenPlaced_ReturnOrderId()
        {
            //arrange
            var storage = new Mock<IStorage>();
            var service = new OrderService(storage.Object);

            //act
            var order = new Order();
            service.PlaceOrder(order);

            //assert
            storage.Verify(s => s.Store(order));

        }
    }
}
