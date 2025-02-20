using Axis.Application.DTOs.HR;
using Axis.Application.Services.IServices.HR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Axis.Api.Controllers
{
    
    public class ContactInfoController : ApiController
    {
        private readonly IContactInfoService _contactInfoService;
        public ContactInfoController(IContactInfoService contactInfoService)
        {
            _contactInfoService = contactInfoService;
        }

        [HttpPost("CreateContactInfo")]
        public async Task<IActionResult> CreateContactInfo(ContactInfoDTO model)
        {
            try
            {
                var res = await _contactInfoService.Add(model);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetContactInfoById")]
        public async Task<IActionResult> GetContactInfoById(string id)
        {
            try
            {
                var data = await _contactInfoService.GetById(id);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("DeleteContactInfo")]
        public async Task<IActionResult> DeleteContactInfo(string id)
        {
            try
            {
                var res = await _contactInfoService.Delete(id);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("UpdateContactInfo")]
        public async Task<IActionResult> UpdateContactInfo(ContactInfoDTO model)
        {
            try
            {
                var res = await _contactInfoService.Update(model);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetContactInfoByComid")]
        public async Task<IActionResult> GetContactInfoByComid(string comid)
        {
            try
            {
                var data = await _contactInfoService.GetListByComid(comid);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
