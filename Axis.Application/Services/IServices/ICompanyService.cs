using Axis.Application.DTOs;
using Axis.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Application.Services.IServices
{
    public interface ICompanyService
    {
        Task<Company> AddCompany(CompanyDTO company);
        Task<Company> UpdateCompany(Company company);
        Task<Company> GetCompany(string id);
        Task<IEnumerable<Company>> GetCompanies();
        Task DeleteCompany(string id);
    }
}
