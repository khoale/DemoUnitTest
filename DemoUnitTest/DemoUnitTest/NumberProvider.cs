using System;
using System.IO;
using System.Linq;

namespace DemoUnitTest
{
    public class NumberProvider : INumberProvider
    {
        public int[] GetNumbers(string fileName)
        {
            var fileContent = File.ReadAllText(fileName);
            return fileContent
                .Split(new[] {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x.Trim()))
                .ToArray();
        }
    }

    public interface INumberProvider
    {
        int[] GetNumbers(string fileName);
    }
}