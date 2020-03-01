using System;

namespace PerfViewPerformanceAnalysisExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Service service = new Service();
            Console.WriteLine(service.GetNamesFaster());
        }
    }
}
