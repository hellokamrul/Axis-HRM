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
                var result =  _unitOfWork.Employees.GetAll().Where(x => x.ComId == comid).ToList(); 
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving employees: {ex.Message}");
                return Enumerable.Empty<Employee>();
            }
        }


        public async Task<Employee> UpdateEmployee(EmployeeDTO employee)
        {
            try
            {
                var empData = _unitOfWork.Employees.GetById(employee.Id);

                if (empData != null)
                {
                    // Update existing employee fields
                   // empData.ComId = employee.ComId;
                    empData.EmpCode = employee.EmpCode;
                    empData.FirstName = employee.FirstName;
                    empData.LastName = employee.LastName;
                    empData.MiddleName = employee.MiddleName;
                    empData.Gender = employee.Gender;
                    empData.DateOfBirth = employee.DateOfBirth;
                    empData.SocialSecurityNumber = employee.SocialSecurityNumber;
                    empData.Email = employee.Email;
                    empData.PhoneNumber = employee.PhoneNumber;
                    empData.EmergencyContactName = employee.EmergencyContactName;
                    empData.EmergencyContactRelationship = employee.EmergencyContactRelationship;
                    empData.EmergencyContactPhone = employee.EmergencyContactPhone;
                   // empData.IsEligibleForBenefits = employee.IsEligibleForBenefits;
                    empData.HealthInsuranceProvider = employee.HealthInsuranceProvider;
                    empData.RetirementPlan = employee.RetirementPlan;
                    empData.Nationality = employee.Nationality;
                    empData.MaritalStatus = employee.MaritalStatus;
                    empData.Skills = employee.Skills;
                    empData.Certifications = employee.Certifications;
                    empData.Notes = employee.Notes;

                    _unitOfWork.Employees.Edit(empData);
                }
                else
                {
                    // If employee does not exist, create a new one
                    empData = _mapper.Map<Employee>(employee);
                    _unitOfWork.Employees.Add(empData);
                }

                // Save changes to the database
                 _unitOfWork.save();

                return empData;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating employee: {ex.Message}");
                return null; // Return null in case of an error
            }
        }


        public (IList<Employee> data, int total, int totalDisplay) GetEmployeesByComid(string comid, int pageIndex, int pageSize, bool isTrackingOff = false)
        {
            var date = _unitOfWork.Employees.Get(
                filter: e => e.ComId == comid,
                orderBy: q => q.OrderBy(e => e.EmpCode),
                pageIndex: pageIndex,
                pageSize: pageSize
            );

            return date;
        }
    }
}
