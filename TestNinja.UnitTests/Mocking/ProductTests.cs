using NUnit.Framework;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class ProductTests
    {
        [Test]
        public void GetPrice_IfCustomerIsGold_ReturnTrue()
        {
            //arrange
           var Product = new Product { ListPrice = 100 };

            //act
            var result = Product.GetPrice(new Customer { IsGold = true });

            //assert
            Assert.That(result, Is.EqualTo(70));
        }
    }

    
}
