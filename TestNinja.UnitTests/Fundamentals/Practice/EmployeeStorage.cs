using NUnit.Framework;
using Moq;
using TestNinja.Mocking.Practice;

namespace TestNinja.UnitTests.Fundamentals.Practice
{
    [TestFixture]
    public class EmployeeStoragePractice
    {
        [Test]
        public void DeleteEmployeeMethod_WhenCalled_DeleteEmployeeRecord()
        {
            var storage = new Mock<IEmployeeStorage1>();
            var controller = new EmployeeController1 (storage.Object);

            controller.DeleteEmployee(1);

            storage.Verify(e => e.DeleteEmployee(1));
        }
    }
}
