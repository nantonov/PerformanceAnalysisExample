using PerfViewPerformanceAnalysisExample.Helpers;
using PerfViewPerformanceAnalysisExample.Models;
using System.Collections.Generic;
using System.Text;

namespace PerfViewPerformanceAnalysisExample
{
    public class Service
    {
        private readonly IEnumerable<Entity> _entities;

        public Service()
        {
            _entities = DataFileGenerator.GenerateData();
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
