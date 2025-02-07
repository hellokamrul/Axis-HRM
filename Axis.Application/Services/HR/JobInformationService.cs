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

namespace Axis.Application.Services
{
    public class JobInformationService : IJobInformationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public JobInformationService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<bool> Add(JobInformationDTO model)
        {
            try
            {
                JobInformation data = _mapper.Map<JobInformation>(model);
                data.Id = Guid.NewGuid().ToString();
                _unitOfWork.JobInformation.Add(data);
                _unitOfWork.save();
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding employee: {ex.Message}");
                return false;
            }
        }

        public async Task<JobInformation> Update(JobInformationDTO model)
        {
            try
            {
                var empData = _unitOfWork.JobInformation.GetById(model.Id);

                if (empData != null)
                {
                    // Update existing employee fields
                    // empData.ComId = employee.ComId;

                    //empData.Notes = model.Notes;

                    _unitOfWork.JobInformation.Edit(empData);
                }
                else
                {
                    // If employee does not exist, create a new one
                    empData = _mapper.Map<JobInformation>(model);
                    _unitOfWork.JobInformation.Add(empData);
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

        public async Task<JobInformationDTO> GetById(string id)
        {
            try
            {
                var data = _unitOfWork.JobInformation.GetById(id);
                JobInformationDTO employee = _mapper.Map<JobInformationDTO>(data);
                return employee;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public Task<IEnumerable<JobInformation>> GetListByComid(string comid)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(string id)
        {
            try
            {
                var data = _unitOfWork.JobInformation.GetById(id);
                if (data != null)
                {
                    _unitOfWork.JobInformation.Remove(data);
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

        public (IList<JobInformation> data, int total, int totalDisplay) GetListWithCount(string comid, int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false)
        {
            throw new NotImplementedException();
        }

    }
}
