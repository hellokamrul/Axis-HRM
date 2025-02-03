using Axis.Application.DTOs;
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
    }
}
