using NUnit.Framework;
using Moq;
using TestNinja.Mocking.Practice;
using System.Net;

namespace TestNinja.UnitTests.Fundamentals.Practice
{
    [TestFixture]
    public class InstallerHelperPracticeTests
    {
        private Mock<IDownloader> _downloader;
        private InstallerHelperPractice _installer;

        [SetUp]
        public void Setup()
        {
            _downloader = new Mock<IDownloader>();
            _installer = new InstallerHelperPractice(_downloader.Object);
        }
        [Test]
        public void DownloadInstaller_DownloadFails_ReturnsFails()
        {
            _downloader.Setup(d => 
               d.DownloadFile(It.IsAny<string>(), It.IsAny<string>())).
               Throws<WebException>();

           var result =  _installer.DownloadInstaller("customer", "installer");

            Assert.That(result, Is.False);

        }
        [Test]
        public void DownloadInstaller_DownloadCompletes_ReturnsTrue()
        {
           

            var result = _installer.DownloadInstaller("customer", "installer");

            Assert.That(result, Is.True);

        }

    }
}
