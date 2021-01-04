using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests.Fundamentals
{
    [TestClass]
    public class ReservationPracticeTests
    {
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //arrange
            var reservation = new Reservation();

            //act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            //assert
            Assert.IsTrue(result);

        }

        [TestMethod]
        public void CanBeCancelledBy_MadeByTheSameUser_ReturnsTrue()
        {
            //arrange
            var user = new User();
            var reservation = new Reservation { MadeBy = user};

            //assert
            var result = reservation.CanBeCancelledBy(user);

            //act
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_AnotherUserCancelling_ReturnFalse()
        {
            var reservation = new Reservation { MadeBy = new User()};

            //act
            var result = reservation.CanBeCancelledBy(new User());

            Assert.IsFalse(result);


        }

    }
}
