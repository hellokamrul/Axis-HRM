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
    public class DepartmentService : IDepartmentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public DepartmentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public Task<bool> Add(DepartmentDTO departmentDTO)
        {
            try
            {
                Department data = _mapper.Map<Department>(departmentDTO);
                data.Id = Guid.NewGuid().ToString();
                _unitOfWork.Departments.Add(data);
                _unitOfWork.save();
                return Task.FromResult(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding department: {ex.Message}");
                return Task.FromResult(false);
            }
        }

        public Task<bool> Delete(string id)
        {
            try
            {
                var data = _unitOfWork.Departments.GetById(id);
                if (data != null)
                {
                    _unitOfWork.Departments.Remove(data);
                    _unitOfWork.save();
                    return Task.FromResult(true);
                }
                else
                {
                    return Task.FromResult(false);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Task.FromResult(false);
            }
        }

        public Task<Department> GetById(string id)
        {
            try
            {
                var data = _unitOfWork.Departments.GetById(id);
                return Task.FromResult(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Task.FromResult(new Department());
            }
        }

        public Task<IEnumerable<Department>> GetListByComid(string id)
        {
            try
            {
                var data = _unitOfWork.Departments.GetAll().Where(x => x.ComId == id);
                return Task.FromResult(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Task.FromResult(Enumerable.Empty<Department>());
            }
        }

        public (IList<Department> data, int total, int totalDisplay) GetPaginatedList(string comid, int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false)
        {
            throw new NotImplementedException();
        }

        public Task<Department> Update(DepartmentDTO departmentDTO)
        {
            try
            {
                Department data = _mapper.Map<Department>(departmentDTO);
                _unitOfWork.Departments.Edit(data);
                _unitOfWork.save();
                return Task.FromResult(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Task.FromResult(new Department());
            }
        }
    }
}
