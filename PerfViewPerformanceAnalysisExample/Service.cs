using System.Text;
using PerfViewPerformanceAnalysisExample.Helpers;
using PerfViewPerformanceAnalysisExample.Models;

namespace PerfViewPerformanceAnalysisExample
{
    public class Service
    {
        private readonly Entity[] _entities;

        public Service()
        {
            _entities = DataGenerator.GenerateData();
        }

        public string GetNames()
        {
            var result = string.Empty;

            foreach (var entity in _entities)
            {
                result += entity.Name;
            }

            return result;
        }

        public string GetNamesFaster()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var entity in _entities)
            {
                sb.Append(entity.Name);
            }

            return sb.ToString();
        }
    }
}
