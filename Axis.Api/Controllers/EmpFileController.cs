using Axis.Application.DTOs.HR;
using Axis.Application.Services.IServices.HR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Axis.Api.Controllers
{
   
    public class EmpFileController : ApiController
    {
        private readonly IEmployeeFileService _empFileService;
        public EmpFileController(IEmployeeFileService empFileService)
        {
            _empFileService = empFileService;
        }
        [HttpPost("CreateEmpFile")]
        public async Task<IActionResult> CreateEmpFile(EmployeeFileDTO model)
        {
            try
            {
                var res = await _empFileService.Add(model);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("GetEmpFileById")]
        public async Task<IActionResult> GetEmpFileById(string id)
        {
            try
            {
                var data = await _empFileService.GetById(id);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("DeleteEmpFile")]
        public async Task<IActionResult> DeleteEmpFile(string id)
        {
            try
            {
                var res = await _empFileService.Delete(id);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("UpdateEmpFile")]
        public async Task<IActionResult> UpdateEmpFile(EmployeeFileDTO model)
        {
            try
            {
                var res = await _empFileService.Update(model);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
