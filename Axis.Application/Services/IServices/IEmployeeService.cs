using Axis.Application.DTOs.HR;
using Axis.Core.Models.HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Application.Services.IServices
{
    public interface IEmployeeService
    {
        Task<bool> AddEmployee(EmployeeDTO employee);
        Task<Employee> UpdateEmployee(EmployeeDTO employee);
        Task<EmployeeDTO> GetEmployee(string id);
        Task<IEnumerable<Employee>> GetEmployees(string comid);
        Task<bool> DeleteEmployee(string id);
       ( IList<Employee> data, int total, int totalDisplay) GetEmployeesByComid(string comid,int pageIndex = 1,int pageSize = 10,bool isTrackingOff = false);
    }
}
