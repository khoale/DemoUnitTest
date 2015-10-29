using System.Collections.Generic;
using Moq;
using Xunit;

namespace DemoUnitTest.Tests
{
    public class NumberServiceIntegrationTest
    {
        private readonly NumberService _sut;

        public NumberServiceIntegrationTest()
        {
            _sut = new NumberService(new NumberProvider());
        }

        [InlineData("Samples/PerfectFile.txt", true)]
        [InlineData("Samples/InPerfectFile.txt", false)]
        [Theory]
        public void IsPerfect(string fileName, bool expectedIsPerfect)
        {
            var result = _sut.IsPerfect(fileName);
            Assert.Equal(expectedIsPerfect, result);
        }
    }
}
