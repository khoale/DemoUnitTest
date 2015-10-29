using System.Linq;

namespace DemoUnitTest
{
    public class NumberService
    {
        private readonly INumberProvider _numberProvider;

        public NumberService(INumberProvider numberProvider)
        {
            _numberProvider = numberProvider;
        }

        public bool IsPerfect(string fileName)
        {
            var numbers = _numberProvider.GetNumbers(fileName);
            return IsPerfect(numbers);
        }

        public bool IsPerfect(int[] numbers)
        {
            var countNegative = numbers.Count(x => x < 0);
            var countPositive = numbers.Count(x => x > 0);
            var sum = numbers.Sum();
            var count = numbers.Count();

            return countNegative == countPositive && sum == 0 && (countNegative + countPositive) == count;
        }
    }
}