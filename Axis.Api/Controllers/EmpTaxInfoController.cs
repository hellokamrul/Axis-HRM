using Axis.Application.DTOs.HR;
using Axis.Application.Services.IServices.HR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Axis.Api.Controllers
{
    
    public class EmpTaxInfoController : ApiController
    {
        private readonly IEmpTaxInfoService _empTaxInfoService;
        public EmpTaxInfoController(IEmpTaxInfoService empTaxInfoService)
        {
            _empTaxInfoService = empTaxInfoService;
        }

        [HttpPost("CreateEmpTaxInfo")]
        public async Task<IActionResult> CreateEmpTaxInfo(EmpTaxInfoDTO model)
        {
            try
            {
                var res = await _empTaxInfoService.Add(model);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetEmpTaxInfoById")]
        public async Task<IActionResult> GetEmpTaxInfoById(string id)
        {
            try
            {
                var data = await _empTaxInfoService.GetById(id);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("DeleteEmpTaxInfo")]
        public async Task<IActionResult> DeleteEmpTaxInfo(string id)
        {
            try
            {
                var res = await _empTaxInfoService.Delete(id);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("UpdateEmpTaxInfo")]
        public async Task<IActionResult> UpdateEmpTaxInfo(EmpTaxInfoDTO model)
        {
            try
            {
                var res = await _empTaxInfoService.Update(model);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }




    }
}
