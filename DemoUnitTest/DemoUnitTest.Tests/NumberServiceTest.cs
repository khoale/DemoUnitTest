using System.Collections.Generic;
using Xunit;
using Xunit.Extensions;

namespace DemoUnitTest.Tests
{
    public class NumberServiceTest
    {
        private readonly NumberService _sut;

        public NumberServiceTest()
        {
            _sut = new NumberService();
        }

        public IEnumerable<object[]> NumberDatas
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
        public void IsPerfect(int[] numbers, bool expectedIsPerfect)
        {
            var result = _sut.IsPerfect(numbers);
            Assert.Equal(expectedIsPerfect, result);
        }

        [MemberData("NumberDatas")]
        public void IsPerfectUsingMock(int[] numbers, bool expectedIsPerfect)
        {
            var result = _sut.IsPerfect(numbers);
            Assert.Equal(expectedIsPerfect, result);
        }
    }
}
