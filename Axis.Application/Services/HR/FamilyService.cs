using AutoMapper;
using Axis.Application.DTOs.HR;
using Axis.Application.Services.IServices;
using Axis.Application.Services.IServices.HR;
using Axis.Core.Models.HR;
using Axis.DataAccess;
using Axis.DataAccess.IRepository;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Application.Services
{
    public class FamilyService : IFamilyService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public FamilyService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

       public async Task<bool> Add(FamilyInfoDTO model)
        {
            try
            {
                FamilyInfo data = _mapper.Map<FamilyInfo>(model);
                data.Id = Guid.NewGuid().ToString();
                _unitOfWork.FamilyInfo.Add(data);
                _unitOfWork.save();
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding employee: {ex.Message}");
                return false;
            }
        }

        public async Task<FamilyInfo> Update(FamilyInfoDTO model)
        {
            try
            {
                var empData = _unitOfWork.FamilyInfo.GetById(model.Id);

                if (empData != null)
                {
                    // Update existing employee fields
                    // empData.ComId = employee.ComId;

                    //empData.Notes = model.Notes;

                    _unitOfWork.FamilyInfo.Edit(empData);
                }
                else
                {
                    // If employee does not exist, create a new one
                    empData = _mapper.Map<FamilyInfo>(model);
                    _unitOfWork.FamilyInfo.Add(empData);
                }


                _unitOfWork.save();

                return empData;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating employee: {ex.Message}");
                return null;
            }
        }

        public async Task<FamilyInfoDTO> GetById(string id)
        {
            try
            {
                var data = _unitOfWork.FamilyInfo.GetById(id);
                FamilyInfoDTO employee = _mapper.Map<FamilyInfoDTO>(data);
                return employee;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public Task<IEnumerable<FamilyInfo>> GetListByComid(string comid)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(string id)
        {
            try
            {
                var data = _unitOfWork.FamilyInfo.GetById(id);
                if (data != null)
                {
                    _unitOfWork.FamilyInfo.Remove(data);
                    _unitOfWork.save();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public (IList<FamilyInfo> data, int total, int totalDisplay) GetListWithCount(string comid, int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<FamilyInfo>> GetListByEmpId(string empid)
        {
            try
            {
                var data = _unitOfWork.FamilyInfo.GetAll().Where(x => x.EmpId == empid).ToList();
                var mappedResult = _mapper.Map<IEnumerable<FamilyInfo>>(data);
                return mappedResult;

            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
