using System;

namespace PerformanceAnalysisExample
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
