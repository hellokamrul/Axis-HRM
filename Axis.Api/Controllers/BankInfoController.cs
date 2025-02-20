using Axis.Application.DTOs.HR;
using Axis.Application.Services.IServices.HR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Axis.Api.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class BankInfoController : ApiController
    {
        private readonly IBankInfoService _service;
        public BankInfoController(IBankInfoService service)
        {
            _service = service;
        }
        [HttpPost("CreateBankInfo")]
        public async Task<IActionResult> CreateBankInfo(BankInfoDTO model)
        {
            try
            {
                var res = await _service.Add(model);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("GetBankInfoById")]
        public async Task<IActionResult> GetBankInfoById(string id)
        {
            try
            {
                var data = await _service.GetById(id);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("DeleteBankInfo")]
        public async Task<IActionResult> DeleteBankInfo(string id)
        {
            try
            {
                var res = await _service.Delete(id);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
