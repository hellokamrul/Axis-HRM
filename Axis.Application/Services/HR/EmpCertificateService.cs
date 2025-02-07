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
    public class EmpCertificateService : IEmpCertificateService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public EmpCertificateService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<bool> Add(EmpCertificateDTO model)
        {
            try
            {
                EmpCertificate data = _mapper.Map<EmpCertificate>(model);
                data.Id = Guid.NewGuid().ToString();
                _unitOfWork.EmpCertificate.Add(data);
                _unitOfWork.save();
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding employee: {ex.Message}");
                return false;
            }
        }

        public async Task<EmpCertificate> Update(EmpCertificateDTO model)
        {
            try
            {
                var empData = _unitOfWork.EmpCertificate.GetById(model.Id);

                if (empData != null)
                {
                    // Update existing employee fields
                    // empData.ComId = employee.ComId;

                    //empData.Notes = model.Notes;

                    _unitOfWork.EmpCertificate.Edit(empData);
                }
                else
                {
                    // If employee does not exist, create a new one
                    empData = _mapper.Map<EmpCertificate>(model);
                    _unitOfWork.EmpCertificate.Add(empData);
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

        public async Task<EmpCertificateDTO> GetById(string id)
        {
            try
            {
                var data = _unitOfWork.EmpCertificate.GetById(id);
                EmpCertificateDTO employee = _mapper.Map<EmpCertificateDTO>(data);
                return employee;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public Task<IEnumerable<EmpCertificate>> GetListByComid(string comid)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(string id)
        {
            try
            {
                var data = _unitOfWork.EmpCertificate.GetById(id);
                if (data != null)
                {
                    _unitOfWork.EmpCertificate.Remove(data);
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

        public (IList<EmpCertificate> data, int total, int totalDisplay) GetListWithCount(string comid, int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false)
        {
            throw new NotImplementedException();
        }

    }
}
