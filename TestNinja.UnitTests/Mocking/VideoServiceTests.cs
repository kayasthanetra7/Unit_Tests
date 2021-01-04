using NUnit.Framework;
using Moq;
using TestNinja.Mocking;
using System.Collections.Generic;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class VideoServiceTests
    {

        private Mock<IVideoRepository1> _repository;
        private Mock<IFileReader> _fileReader;

        [SetUp]
        public void Setup()
        {
            _repository = new Mock<IVideoRepository1>();
            _fileReader = new Mock<IFileReader>();

        }
        [Test]
        public void ReadVideoTitle_EmptyFile_ReturnError()
        {
            
            var videoService = new VideoService(_fileReader.Object);

            _fileReader.Setup(fr => fr.Read("video.txt")).Returns("");
            
            var result = videoService.ReadVideoTitle();

            Assert.That(result, Does.Contain("error").IgnoreCase);

        }

        [Test]
        public void GetUnprocessedVideosAsCSV_AllVideosAreProcessed_ReturnAnEmptyString()
        {

            var VideoService = new VideoService(_fileReader.Object, _repository.Object);

            _repository.Setup(r => r.GetUnprocessedVideos()).Returns(new List<Video>());

            var result = VideoService.GetUnprocessedVideosAsCsv();

            Assert.That(result, Is.EqualTo(""));
           
        }

        [Test]
        public void GetUnprocessedVideosAsCSV_AFewUnprocessedVideos_ReturnAStringWithIDOfUnprocessedVideos()
        {

            var VideoService = new VideoService(_fileReader.Object, _repository.Object);

            _repository.Setup(r => r.GetUnprocessedVideos()).Returns(new List<Video>
            {
                new Video { Id = 1},
                new Video { Id = 2},
                new Video { Id = 3},

            }) ;

            var result = VideoService.GetUnprocessedVideosAsCsv();

            Assert.That(result, Is.EqualTo("1,2,3"));


        }





    }
}
