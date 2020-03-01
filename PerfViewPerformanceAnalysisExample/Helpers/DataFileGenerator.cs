using PerfViewPerformanceAnalysisExample.Models;
using System;
using System.Text;

namespace PerfViewPerformanceAnalysisExample.Helpers
{
    public static class DataFileGenerator
    {
        public const int EntitiesCount = 100000;

        public static Entity[] GenerateData()
        {
            var entities = new Entity[EntitiesCount];

            for (var i = 0; i < EntitiesCount; i++)
            {
                entities[i] = new Entity
                {
                    Name = GenerateRandomString()
                };
            }

            return entities;
        }

        private static string GenerateRandomString()
        {
            var random = new Random();
            var length = random.Next(1, 10);
            var stringBuilder = new StringBuilder();

            for (var i = 0; i < length; i++)
            {
                var flt = random.NextDouble();
                var shift = Convert.ToInt32(Math.Floor(25 * flt));
                var letter = Convert.ToChar(shift + 65);
                stringBuilder.Append(letter);
            }

            return stringBuilder.ToString();
        }
    }
}
