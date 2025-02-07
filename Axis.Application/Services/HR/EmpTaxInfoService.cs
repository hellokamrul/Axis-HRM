using AutoMapper;
using Axis.Application.DTOs.HR;
using Axis.Application.Services.IServices;
using Axis.Application.Services.IServices.HR;
using Axis.Core.Models.HR;
using Axis.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Application.HR.Services
{
    public class EmpTaxInfoService : IEmpTaxInfoService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public EmpTaxInfoService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<bool> Add(EmpTaxInfoDTO model)
        {
            try
            {
                EmpTaxInfo data = _mapper.Map<EmpTaxInfo>(model);
                data.Id = Guid.NewGuid().ToString();
                _unitOfWork.EmpTaxInfo.Add(data);
                _unitOfWork.save();
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding employee: {ex.Message}");
                return false;
            }
        }

        public async Task<EmpTaxInfo> Update(EmpTaxInfoDTO model)
        {
            try
            {
                var empData = _unitOfWork.EmpTaxInfo.GetById(model.Id);

                if (empData != null)
                {
                    // Update existing employee fields
                    // empData.ComId = employee.ComId;

                    //empData.Notes = model.Notes;

                    _unitOfWork.EmpTaxInfo.Edit(empData);
                }
                else
                {
                    // If employee does not exist, create a new one
                    empData = _mapper.Map<EmpTaxInfo>(model);
                    _unitOfWork.EmpTaxInfo.Add(empData);
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

        public async Task<EmpTaxInfoDTO> GetById(string id)
        {
            try
            {
                var data = _unitOfWork.EmpTaxInfo.GetById(id);
                EmpTaxInfoDTO employee = _mapper.Map<EmpTaxInfoDTO>(data);
                return employee;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public Task<IEnumerable<EmpTaxInfo>> GetListByComid(string comid)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(string id)
        {
            try
            {
                var data = _unitOfWork.EmpTaxInfo.GetById(id);
                if (data != null)
                {
                    _unitOfWork.EmpTaxInfo.Remove(data);
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

        public (IList<EmpTaxInfo> data, int total, int totalDisplay) GetListWithCount(string comid, int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false)
        {
            throw new NotImplementedException();
        }

    }
}
