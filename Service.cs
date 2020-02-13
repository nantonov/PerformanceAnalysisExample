﻿using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using PerformanceAnalysisExample.Models;

namespace PerformanceAnalysisExample
{
    public class Service
    {
        private readonly IEnumerable<Entity> _entities;

        public Service()
        {
            var data = File.ReadAllText(@"data.json");
            _entities = JsonConvert.DeserializeObject<List<Entity>>(data);
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
