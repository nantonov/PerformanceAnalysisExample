using BenchmarkDotNet.Running;

namespace PerformanceAnalysisExample
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<Service>();
        }
    }
}
