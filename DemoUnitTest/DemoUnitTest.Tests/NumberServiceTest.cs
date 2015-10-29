using System.Collections.Generic;
using Moq;
using Xunit;

namespace DemoUnitTest.Tests
{
    public class NumberServiceTest
    {
        private readonly Mock<INumberProvider> _mockNumberProvider;
        private readonly NumberService _sut;

        public NumberServiceTest()
        {
            _mockNumberProvider = new Mock<INumberProvider>();
            _sut = new NumberService(_mockNumberProvider.Object);
        }

        public static IEnumerable<object[]> NumberDatas
        {
            get
            {
                return new[]
                {
                    new object[] {new[] {-1, 2, 3, -4}, true},
                    new object[] {new[] {-1, 2, 3, -4, 0}, false},
                };
            }
        }

        [MemberData("NumberDatas")]
        [Theory]
        public void IsPerfect(int[] numbers, bool expectedIsPerfect)
        {
            var result = _sut.IsPerfect(numbers);
            Assert.Equal(expectedIsPerfect, result);
        }

        [MemberData("NumberDatas")]
        [Theory]
        public void IsPerfectUsingMock(int[] numbers, bool expectedIsPerfect)
        {
            _mockNumberProvider.Setup(x => x.GetNumbers(It.IsAny<string>()))
                .Returns(numbers);

            var result = _sut.IsPerfect("anoynmous");
            Assert.Equal(expectedIsPerfect, result);
        }
    }
}
