using AutoMapper;
using Axis.Application.DTOs;
using Axis.Application.Services.IServices;
using Axis.Core.Models.HR;
using Axis.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Application.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public EmployeeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<bool> AddEmployee(EmployeeDTO employee)
        {
            try
            {
                var data = _mapper.Map<Employee>(employee);
                data.Id = Guid.NewGuid().ToString();
                _unitOfWork.Employees.Add(data);
                _unitOfWork.save();
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding employee: {ex.Message}");
                return false;
            }
        }


        public async Task<bool> DeleteEmployee(string id)
        {
            try
            {
                var data = _unitOfWork.Employees.GetById(id);
                if (data != null)
                {
                    _unitOfWork.Employees.Remove(data);
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

        public async Task<EmployeeDTO> GetEmployee(string id)
        {
            try
            {
                var data = _unitOfWork.Employees.GetById(id);
                EmployeeDTO employee = _mapper.Map<EmployeeDTO>(data);
                return employee;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<IEnumerable<Employee>> GetEmployees(string comid)
        {
            try
            {
                // Ensure the Employee entity contains a 'CompanyId' property
                //var result = await _unitOfWork.Employees.GetDynamicAsync(
                //    filter: e => e.ComId == comid, 
                //    orderBy: null,                     
                //    pageIndex: 1,
                //    pageSize: 100,                     
                //    isTrackingOff: true
                //);
                var result =  _unitOfWork.Employees.GetAll().Where(x => x.ComId == comid).ToList();

                //IList<Employee> employees = result;
                //int total = result.total; 
                //int totalDisplay = result.totalDisplay; 

               
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving employees: {ex.Message}");
                return Enumerable.Empty<Employee>(); // Return an empty list in case of failure
            }
        }


        public Task<Employee> UpdateEmployee(EmployeeDTO employee)
        {
            throw new NotImplementedException();
        }

       
    }
}
