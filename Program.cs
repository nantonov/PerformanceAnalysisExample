using System;

namespace PerformanceAnalysisExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Service service = new Service();
            var names = service.GetNames();
            Console.WriteLine(names);
        }
    }
}
