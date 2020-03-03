using System;

namespace PerfViewPerformanceAnalysisExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new Service();
            var names = service.GetNames();
            Console.WriteLine(names);
        }
    }
}
