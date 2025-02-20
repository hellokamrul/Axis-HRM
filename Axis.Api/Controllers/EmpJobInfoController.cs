using Axis.Application.DTOs.HR;
using Axis.Application.Services.IServices.HR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Axis.Api.Controllers
{
    
    public class EmpJobInfoController : ApiController
    {
        private readonly IJobInformationService _empJobInfoService;

        public EmpJobInfoController(IJobInformationService empJobInfoService)
        {
            _empJobInfoService = empJobInfoService;
        }

        [HttpPost("CreateEmpJobInfo")]
        public async Task<IActionResult> CreateEmpJobInfo(JobInformationDTO model)
        {
            try
            {
                var res = await _empJobInfoService.Add(model);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetEmpJobInfoById")]
        public async Task<IActionResult> GetEmpJobInfoById(string id)
        {
            try
            {
                var data = await _empJobInfoService.GetById(id);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("DeleteEmpJobInfo")]
        public async Task<IActionResult> DeleteEmpJobInfo(string id)
        {
            try
            {
                var res = await _empJobInfoService.Delete(id);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("UpdateEmpJobInfo")]
        public async Task<IActionResult> UpdateEmpJobInfo(JobInformationDTO model)
        {
            try
            {
                var res = await _empJobInfoService.Update(model);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }




    }
}
