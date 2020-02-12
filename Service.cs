using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using BenchmarkDotNet.Attributes;
using Newtonsoft.Json;
using PerformanceAnalysisExample.Models;

namespace PerformanceAnalysisExample
{
    public class Service
    {
        private readonly IEnumerable<Entity> _entities;

        public Service()
        {
            var data = File.ReadAllText(@"C:\Users\m.antonau\source\repos\PerformanceAnalysisExample\bin\Release\netcoreapp3.1\data.json");
            _entities = JsonConvert.DeserializeObject<List<Entity>>(data);
        }

        [Benchmark]
        public string GetNames()
        {
            var result = string.Empty;

            foreach (var entity in _entities)
            {
                if (entity.Date > DateTime.UtcNow)
                {
                    result += entity.Name;
                }
            }

            return result;
        }

        [Benchmark]
        public string GetNamesFaster()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var entity in _entities)
            {
                if (entity.Date > DateTime.UtcNow)
                {
                    sb.Append(entity.Name);
                }
            }

            return sb.ToString();
        }
    }
}
