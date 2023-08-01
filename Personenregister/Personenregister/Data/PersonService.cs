using System;
using System.Linq;
using System.Threading.Tasks;

namespace Personenregister.Data
{
    public class PersonService
    {
        private static readonly string[] Summaries = new[]
        {
            "Kirk", "James", "Lars", "Robert", "Cliff", "Jason"
        };

        public Task<RegistryC[]> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new RegistryC
            {
                Name = "l",
                PreName = Summaries[rng.Next(Summaries.Length)],
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray());
        }
    }
}
