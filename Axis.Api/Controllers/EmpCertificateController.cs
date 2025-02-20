using Axis.Application.DTOs.HR;
using Axis.Application.Services.IServices.HR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Axis.Api.Controllers
{
   
    public class EmpCertificateController : ApiController
    {
        private readonly IEmpCertificateService _empCertificateService;
        public EmpCertificateController( IEmpCertificateService certificateService) {

            _empCertificateService = certificateService;
        }

        [HttpPost("CreateEmpCertificate")]
        public async Task<IActionResult> CreateEmpCertificate(EmpCertificateDTO model)
        {
            try
            {
                var res = await _empCertificateService.Add(model);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet("GetEmpCertificateById")]
        public async Task<IActionResult> GetEmpCertificateById(string id)
        {
            try
            {
                var data = await _empCertificateService.GetById(id);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("DeleteEmpCertificate")]
        public async Task<IActionResult> DeleteEmpCertificate(string id)
        {
            try
            {
                var res = await _empCertificateService.Delete(id);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("UpdateEmpCertificate")]
        public async Task<IActionResult> UpdateEmpCertificate(EmpCertificateDTO model)
        {
            try
            {
                var res = await _empCertificateService.Update(model);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



    }
}
