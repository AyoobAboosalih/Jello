using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jello.Data
{
    public class CompanyService
    {
        private static readonly string[] CompanyNames = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };



        public Task<Company[]> GetCompanies()
        {
            var randint = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new Company
            {
                Id = Guid.NewGuid(),
                Name = CompanyNames[randint.Next(CompanyNames.Length)]
            }).ToArray());
        }
    }
}
