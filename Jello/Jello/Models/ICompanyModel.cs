using Jello.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jello.Models
{
    interface ICompanyModel
    {
        List<Company> GetCompanies();
        Company GetCompanyById(Guid id);
        void SaveCompany(Company company);
        void DeleteCompany(Guid id);
    }
}
