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
    public class BankInfoService : IBankInfoService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public BankInfoService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<bool> Add(BankInfoDTO model)
        {
            try
            {
                var data = _mapper.Map<BankInfo>(model);
                data.Id = Guid.NewGuid().ToString();
                _unitOfWork.BankInfo.Add(data);
                _unitOfWork.save();
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding employee: {ex.Message}");
                return false;
            }
        }


        public async Task<bool> Delete(string id)
        {
            try
            {
                var data = _unitOfWork.BankInfo.GetById(id);
                if (data != null)
                {
                    _unitOfWork.BankInfo.Remove(data);
                    _unitOfWork.save();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex) { 
                Console.WriteLine(ex.Message ); 
                return false;
            }
          
        }

        public async Task<BankInfoDTO> GetById(string id)
        {
            try
            {
                var data = _unitOfWork.Employees.GetById(id);
                BankInfoDTO employee = _mapper.Map<BankInfoDTO>(data);
                return employee;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<IEnumerable<BankInfo>> GetListByComid(string comid)
        {
            try
            {
                var result =  _unitOfWork.BankInfo.GetAll().Where(x => x.ComId == comid).ToList(); 
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving employees: {ex.Message}");
                return Enumerable.Empty<BankInfo>();
            }
        }


        public async Task<BankInfo> Update(BankInfoDTO model)
        {
            try
            {
                var data =  _unitOfWork.Employees.GetById(model.Id);

                if (data != null)
                {
                    // Update existing employee fields
                   // empData.ComId = employee.ComId;

                    _unitOfWork.Employees.Edit(data);
                }
                else
                {
                    // If employee does not exist, create a new one
                  var  bankData = _mapper.Map<BankInfo>(model);
                    _unitOfWork.BankInfo.Add(bankData);
                    //_unitOfWork.save();
                }

              
                 _unitOfWork.save();

                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating employee: {ex.Message}");
                return null;
            }
        }


        public (IList<BankInfo> data, int total, int totalDisplay) GetListWithCount(string comid, int pageIndex, int pageSize, bool isTrackingOff = false)
        {
            var date = _unitOfWork.BankInfo.Get(
                filter: e => e.ComId == comid,
                orderBy: q => q.OrderBy(e => e.Id),
                pageIndex: pageIndex,
                pageSize: pageSize
            );

            return date;
        }
    }
}
