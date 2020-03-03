using PerfViewPerformanceAnalysisExample.Models;
using System;
using System.Text;

namespace PerfViewPerformanceAnalysisExample.Helpers
{
    public static class DataFileGenerator
    {
        private const int EntitiesCount = 1000000;
        private static readonly Random Random = new Random();

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
            var length = Random.Next(1, 10);
            var stringBuilder = new StringBuilder(length);

            for (var i = 0; i < length; i++)
            {
                var flt = Random.NextDouble();
                var shift = Convert.ToInt32(Math.Floor(25 * flt));
                var letter = Convert.ToChar(shift + 65);
                stringBuilder.Append(letter);
            }

            return stringBuilder.ToString();
        }
    }
}
