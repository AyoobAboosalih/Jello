using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jello.Data;
using Microsoft.EntityFrameworkCore;

namespace Jello.Models
{
    public class CompanyModel : ICompanyModel
    {

        private readonly ApplicationDbContext _dbContext;
        public CompanyModel(ApplicationDbContext context)
        {
            _dbContext = context;
        }
        public void DeleteCompany(Guid id)
        {
            var company = _dbContext.Companies.FirstOrDefault(x => x.Id == id);
            if (company != null)
            {
                _dbContext.Companies.Remove(company);
                _dbContext.SaveChanges();
            }
        }

        public List<Company> GetCompanies()
        {
            return _dbContext.Companies.ToList();
        }

        public Company GetCompanyById(Guid id)
        {
            var company = _dbContext.Companies.SingleOrDefault(x => x.Id == id);
            return company;
        }

        public void SaveCompany(Company company)
        {
            if (company.Id.Equals(0)) {
                company.Id = new Guid();
                _dbContext.Companies.Add(company);
            } 
            else _dbContext.Companies.Update(company);
            _dbContext.SaveChanges();

        }
    }
}
