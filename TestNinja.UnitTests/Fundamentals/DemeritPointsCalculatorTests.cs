using NUnit.Framework;
using System;

namespace TestNinja.Fundamentals
{
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
       [Test]
       [TestCase(-10)]
       [TestCase(400)]
       public void DemeritPointsCalculator_SpeedIsLessThanZeroOrMoreThan300_ThrowsArgumentOutOfRangeException(int speed)
        {
            //arrange
            var demeritPoints = new DemeritPointsCalculator();

            //act
            //var result = demeritPoints.CalculateDemeritPoints(-10);

            //assert
            Assert.That(() => demeritPoints.CalculateDemeritPoints(speed), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());

        }

        [Test]
        [TestCase(0,0)]
        [TestCase(64,0)]
        [TestCase(65,0)]
        [TestCase(66,0)]
        [TestCase(70,1)]
        [TestCase(75,2)]

        public void DemeritPointsCalculator_WhenCalled_ReturnDemeritPoints(int speed, int expectedResult)
        {
            var demeritPoints = new DemeritPointsCalculator();

            var result = demeritPoints.CalculateDemeritPoints(speed);

            Assert.That(result, Is.EqualTo(expectedResult));



        }

       
    }
}
