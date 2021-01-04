using System;
using NUnit.Framework;


namespace TestNinja.Fundamentals
{
    [TestFixture]
    public class FizzBuzzPractice
    {
        [Test]
        public void GetOutput_NumberNotDivisbleby3and5_ReturnFizzBuzz()
        {

            var output = FizzBuzz.GetOutput(8);
            Assert.That(output, Is.EqualTo("8"));
            

            
        }
    }
}
