using System;
using Xunit;
using SampleService;

namespace SampleService.Tests
{
    public class SampleServiceTests
    {
        [Fact]
        public void Test1()
        {
            var service = new SampleService();
            var actual = service.Add(1, 2);
            Assert.Equal<int>(3, actual);
        }
    }
}
