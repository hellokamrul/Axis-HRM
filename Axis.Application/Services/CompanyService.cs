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

        public async Task<bool> AddCompany(CompanyDTO company)
        {
            try
            {
                var data = _mapper.Map<Company>(company);
                data.ComId = Guid.NewGuid().ToString();
                 _unitOfWork.Companies.Add(data);
                _unitOfWork.save();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

               
        }

        public async Task DeleteCompany(string id)
        {
            var data = _unitOfWork.Companies.GetById(id);
            try
            {
                if (data != null)
                {
                    _unitOfWork.Companies.Remove(id);
                    _unitOfWork.save();                                       
                }
            }
            catch (Exception ex) 
            { 
                throw ex;
            }
        }

        public async Task<IEnumerable<Company>> GetCompanies()
        {
            try
            {
                var data = _unitOfWork.Companies.GetAll();
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<Company> GetCompany(string id)
        {
            try
            {
                var data = _unitOfWork.Companies.GetById(id);
                return Task.FromResult(data);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public async Task<Company> UpdateCompany(CompanyDTO company)
        {
            try
            {
                var existingCompany =  _unitOfWork.Companies.GetById(company.Comid);
                if (existingCompany == null)
                {
                    throw new KeyNotFoundException("Company not found.");
                }

                existingCompany.Name = company.Name;
               // existingCompany.Address = company.Address;
               // existingCompany.Phone = company.Phone;

                _unitOfWork.Companies.Edit(existingCompany);
                _unitOfWork.save();

                return existingCompany;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while updating the company.", ex);
            }
        }

    }
}
