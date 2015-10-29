using System;

namespace DemoUnitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileName = args[0];
            var numberService = new NumberService(new NumberProvider());
            var isPerfect = numberService.IsPerfect(fileName);
            if (isPerfect)
            {
                Console.WriteLine("File is Perfect");
            }
            else
            {
                Console.WriteLine("File is InPerfect");
            }

            Console.ReadKey();
        }
    }
}
