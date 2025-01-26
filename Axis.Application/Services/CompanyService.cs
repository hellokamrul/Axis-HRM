using AutoMapper;
using Axis.Application.DTOs;
using Axis.Application.Services.IServices;
using Axis.Core.Models;
using Axis.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Application.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CompanyService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Company> AddCompany(CompanyDTO company)
        {
            try
            {
                var data = _mapper.Map<Company>(company);
                await _unitOfWork.Companies.AddAsync(data);
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }

               
        }

        public Task DeleteCompany(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Company>> GetCompanies()
        {
            throw new NotImplementedException();
        }

        public Task<Company> GetCompany(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Company> UpdateCompany(Company company)
        {
            throw new NotImplementedException();
        }
    }
}
