using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrange
            var reservation = new Reservation();

            //Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            //Assert
            Assert.That(result == true);

        }

        [Test]
        public void CanBeCancelledBy_SameUserCancellingReservation_ReturnsTrue()
        {
            //arrange
            var user = new User();
            var reservation = new Reservation { MadeBy = user };

            //act
            var result = reservation.CanBeCancelledBy(user);

            //assert
            Assert.That(result, Is.True);

        }
        
        [Test]
        public void CanBeCancelledBy_AnotherUserCancellingReservation_ReturnsFalse()
        {
            //arrange
            var reservation = new Reservation { MadeBy = new User()};

            //act
            var result = reservation.CanBeCancelledBy(new User());

            //assert
            Assert.That(result == false);

        }

        


    }
}
