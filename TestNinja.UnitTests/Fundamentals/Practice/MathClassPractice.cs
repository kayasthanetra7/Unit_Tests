using NUnit.Framework;
using System.Linq;

namespace TestNinja.Fundamentals
{
    [TestFixture]
    public class MathClassPractice
    {
        private Math _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        [Test]
        public void Math_AddTwoNumbers_ReturnSum()
        {
            //var output = new Math();
            var result = _math.Add(1, 2);
            Assert.AreEqual(result, 3);
        }

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]

        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedOutput)
        {
            //var output = new Math();
            var result = _math.Max(a, b);
            Assert.AreEqual(result, expectedOutput);
        }
        /*[Test]
        public void Math_BIsGreaterThanA_ReturnB()
        {
            //var _math = new Math();
            var result = _math.Max(1, 2);
            Assert.AreEqual(result, 2);
        }

        [Test]
        public void Math_AIsEqualToB_ReturnA()
        {
            //var _math = new Math();
            var result = _math.Max(1, 1);
            Assert.AreEqual(result, 1);
        }*/

        [Test]
        public void GetOddNumbers_LimitIsGreaterThan0_ReturnOddNumbers()
        {
            //var output = new Math();
            var result = _math.GetOddNumbers(5);
            //Assert
            Assert.That(result, Is.Not.Empty);

            Assert.That(result.Count(), Is.EqualTo(3));

            Assert.That(result, Does.Contain(1));
            Assert.That(result, Does.Contain(3));
            Assert.That(result, Does.Contain(5));

            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));

        }

        [Test]
        public void GetOddNumbers_LimitIsLessThan0_ReturnOddNumbers()
        {
            //var output = new Math();
            var result = _math.GetOddNumbers(-5);

            //Assert
            Assert.That(result, Is.Not.Empty);

            Assert.That(result.Count(), Is.EqualTo(3));

            Assert.That(result, Does.Contain(-1));
            Assert.That(result, Does.Contain(-3));
            Assert.That(result, Does.Contain(-5));

            Assert.That(result, Is.EquivalentTo(new[] { -1, -3, -5 }));
        }


    }
}
