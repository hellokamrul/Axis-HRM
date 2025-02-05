using Axis.Application.DTOs;
using Axis.Application.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Axis.Api.Controllers
{
    public class EmployeeController : ApiController
    {
        private readonly IEmployeeService _service;
        public EmployeeController(IEmployeeService service) { 
        
            _service = service;
        
        }


        [HttpPost("CreateEmployee")]
        public async Task<IActionResult> CreateEmployee(EmployeeDTO model)
        {
            try
            {
                var res = await _service.AddEmployee(model);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetEmployeeByComid")]

        public async Task<IActionResult> GetEmployeeList(string Comid)
        {
            try
            {
                var data = await _service.GetEmployees(Comid);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetEmp")]
        public IActionResult GetEmployeeList(string comid, int pageIndex = 1, int pageSize = 10)
        {
            try
            {
                var (data, total, totalDisplay) = _service.GetEmployeesByComid(comid, pageIndex, pageSize);
                return Ok(new { Employees = data, Total = total, TotalDisplay = totalDisplay });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = ex.Message });
            }
        }

    }
}
