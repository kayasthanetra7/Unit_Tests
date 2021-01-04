using System.Collections.Generic;

namespace TestNinja.Mocking
{
    interface IVideoRepository
    {
        IEnumerable<Video> GetUnprocessedVideos();
    }
}