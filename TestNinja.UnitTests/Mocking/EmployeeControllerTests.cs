using NUnit.Framework;
using TestNinja.Mocking;
using Moq;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class EmployeeControllerTests
    {
        [Test]
        public void DeleteEmployee_WhenCalled_DeleteEmployeeRecord()
        {
            //arrange
            var storage = new Mock<IEmployeeStorage>();
            var controller = new EmployeeController(storage.Object);

            //act
            var result = controller.DeleteEmployee(1);

            //assert
            storage.Verify(s => s.DeleteEmployee(1));

           
        }
    }
}
