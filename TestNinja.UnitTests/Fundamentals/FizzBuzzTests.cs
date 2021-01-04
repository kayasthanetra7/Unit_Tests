using NUnit.Framework;

namespace TestNinja.Fundamentals
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void GetOutput_DivisibleBy3And5_ReturnFizzBuzz()
        {

            //act
            var result = FizzBuzz.GetOutput(15);

            //assert
            Assert.That(result, Is.EqualTo("FizzBuzz"));

        }

        [Test]
        public void GetOutput_DivisibleByOnly3_ReturnFizz()
        {
            var result = FizzBuzz.GetOutput(12);

            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void GetOutput_DivisibleByOnly5_ReturnBuzz()
        {
            var result = FizzBuzz.GetOutput(10);

            Assert.That(result, Is.EqualTo("Buzz"));

        }

        [Test]
        public void GetOutPut_DivisibleByNeither3Or5_ReturnSameNumber()
        {
            var result = FizzBuzz.GetOutput(8);

            Assert.That(result, Is.EqualTo("8"));

        }
    }

}
