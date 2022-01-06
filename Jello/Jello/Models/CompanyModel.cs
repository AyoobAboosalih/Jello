using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jello.Data;
using Microsoft.EntityFrameworkCore;

namespace Jello.Models
{
    public class CompanyModel
    {

        private readonly ApplicationDbContext _dbContext;
        public CompanyModel(ApplicationDbContext context)
        {
            _dbContext = context;
        }
        public async Task<bool> DeleteCompany(Guid id)
        {
            var company = _dbContext.Companies.FirstOrDefault(x => x.Id == id);
            if (company != null)
            {
                _dbContext.Companies.Remove(company);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<List<Company>> GetCompanies()
        {
            return await _dbContext.Companies.ToListAsync();
        }

        public async Task<Company>  GetCompanyById(Guid id)
        {
            var company = await _dbContext.Companies.FirstOrDefaultAsync(x => x.Id == id);
            return company;
        }

        public async Task<bool> SaveCompany(Company company)
        {
            if (company.Id.Equals(0)) {
                company.Id = new Guid();
                await _dbContext.Companies.AddAsync(company);
            } 
            else _dbContext.Companies.Update(company);
            await _dbContext.SaveChangesAsync();
            return true;

        }
    }
}
