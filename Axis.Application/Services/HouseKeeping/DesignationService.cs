using AutoMapper;
using Axis.Application.DTOs.HouseKeeping;
using Axis.Application.Services.IServices.HouseKeeping;
using Axis.Core.Models.HouseKeeping;
using Axis.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Application.Services.HouseKeeping
{
    public class DesignationService : IDesignationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public DesignationService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<bool> Add(DesignationDTO departmentDTO)
        {
            try
            {
                Designation data = _mapper.Map<Designation>(departmentDTO);
                data.Id = Guid.NewGuid().ToString();
                _unitOfWork.Designations.Add(data);
                _unitOfWork.save();
                return  await Task.FromResult(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding department: {ex.Message}");
                return await Task.FromResult(false);
            }
        }

        public async Task<bool> Delete(string id)
        {
            try
            {
                var data = _unitOfWork.Designations.GetById(id);

                if (data != null)
                {
                    _unitOfWork.Designations.Remove(data);
                    _unitOfWork.save();
                    return await Task.FromResult(true);
                }
                else
                {
                    return await Task.FromResult(false);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return await Task.FromResult(false);
            }
        }

        public async Task<Designation> GetById(string id)
        {
            try
            {
                var data =  _unitOfWork.Designations.GetById(id);
                return await Task.FromResult(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return  new Designation { };
            }
        }

        public async Task<IEnumerable<Designation>> GetListByComid(string id)
        {
            try
            {
                var data =  _unitOfWork.Designations.GetAll().Where(x => x.ComId == id);
                return await Task.FromResult(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return  null;
            }
        }

        public Task<IEnumerable<Designation>> GetListByDeptId(string id)
        {
            try
            {
                var data = _unitOfWork.Designations.GetAll().Where(x => x.DeptId == id);
                return Task.FromResult(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }

        public (IList<Designation> data, int total, int totalDisplay) GetPaginatedList(string comid, int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false)
        {
            throw new NotImplementedException();
        }

        public Task<Designation> Update(DesignationDTO departmentDTO)
        {
            try
            {
                var data = _unitOfWork.Designations.GetById(departmentDTO.Id);
                if (data != null)
                {
                    data.ComId = departmentDTO.ComId;
                    data.DeptId = departmentDTO.DeptId;
                    data.DesigName = departmentDTO.DesigName;
                    //data. = departmentDTO.Description;
                    //data.IsActive = departmentDTO.IsActive;
                    //data.UpdatedBy = departmentDTO.UpdatedBy;
                    //data.UpdatedDate = DateTime.Now;
                    _unitOfWork.Designations.Edit(data);
                }
                else
                {
                    var departmentData = _mapper.Map<Designation>(departmentDTO);
                    _unitOfWork.Designations.Add(departmentData);
                }
                _unitOfWork.save();
                return Task.FromResult(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating department: {ex.Message}");
                return null;
            }
        }
    }
}
