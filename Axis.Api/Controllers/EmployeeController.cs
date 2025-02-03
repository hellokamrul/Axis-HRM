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
                var res = _service.AddEmployee(model);
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
                var data = _service.GetEmployees(Comid);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
