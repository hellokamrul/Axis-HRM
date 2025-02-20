using Axis.Application.DTOs.HR;
using Axis.Application.Services.IServices.HR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Axis.Api.Controllers
{
    
    public class EmpAddressController : ApiController
    {
        private readonly IEmployeeAddressService _empAddressService;
        public EmpAddressController( IEmployeeAddressService employeeAddress)
        {
            _empAddressService = employeeAddress;
        }

        [HttpPost("CreateEmpAddress")]
        public async Task<IActionResult> CreateEmpAddress(EmployeeAddressDTO model)
        {
            try
            {
                var res = await _empAddressService.Add(model);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetEmpAddressById")]
        public async Task<IActionResult> GetEmpAddressById(string id)
        {
            try
            {
                var data = await _empAddressService.GetById(id);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("DeleteEmpAddress")]
        public async Task<IActionResult> DeleteEmpAddress(string id)
        {
            try
            {
                var res = await _empAddressService.Delete(id);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("UpdateEmpAddress")]
        public async Task<IActionResult> UpdateEmpAddress(EmployeeAddressDTO model)
        {
            try
            {
                var res = await _empAddressService.Update(model);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
    
}
