using System;

namespace PerfViewPerformanceAnalysisExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new Service();
            var names = service.GetNamesFaster();
            Console.WriteLine(names);
        }
    }
}
