using NUnit.Framework;


namespace TestNinja.Fundamentals
{
    [TestFixture]
    public class HtmlClassTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement()
        {
            //arrange
            var formatter = new HtmlFormatter();

            //act
            var result = formatter.FormatAsBold("abc");

            //assert
            Assert.That(result, Is.EqualTo("<strong>abc</strong>").IgnoreCase);

            //Assert.That(result, Does.StartWith("<strong>"));
        }

    }
}
