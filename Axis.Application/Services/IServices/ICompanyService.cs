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
        Task<bool> AddCompany(CompanyDTO company);
        Task<Company> UpdateCompany(CompanyDTO company);
        Task<Company> GetCompany(string id);
        Task<IEnumerable<Company>> GetCompanies();
        Task DeleteCompany(string id);
    }
}
