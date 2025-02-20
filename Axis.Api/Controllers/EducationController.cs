using Axis.Application.DTOs.HR;
using Axis.Application.Services.IServices.HR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Axis.Api.Controllers
{
    
    public class EducationController : ApiController
    {
        private readonly IEducationService _educationService;
        public EducationController(IEducationService edcationService)
        {
            _educationService = edcationService;    
        }

        [HttpPost("CreateEducation")]
        public async Task<IActionResult> CreateEducation(EducationDTO model)
        {
            try
            {
                var res = await _educationService.Add(model);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetEducationById")]
        public async Task<IActionResult> GetEducationById(string id)
        {
            try
            {
                var data = await _educationService.GetById(id);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("DeleteEducation")]
        public async Task<IActionResult> DeleteEducation(string id)
        {
            try
            {
                var res = await _educationService.Delete(id);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("UpdateEducation")]
        public async Task<IActionResult> UpdateEducation(EducationDTO model)
        {
            try
            {
                var res = await _educationService.Update(model);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}
