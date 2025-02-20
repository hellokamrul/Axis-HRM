using Axis.Application.DTOs.HR;
using Axis.Application.Services.IServices.HR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Axis.Api.Controllers
{
    public class EmpWokrExperienceController : ApiController
    {
        private readonly IWorkExperienceService _empWorkExperienceService;

        public EmpWokrExperienceController(IWorkExperienceService empWorkExperienceService)
        {
            _empWorkExperienceService = empWorkExperienceService;
        }

        [HttpPost("CreateEmpWorkExperience")]
        public async Task<IActionResult> CreateEmpWorkExperience(WorkExperienceDTO model)
        {
            try
            {
                var res = await _empWorkExperienceService.Add(model);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetEmpWorkExperienceById")]
        public async Task<IActionResult> GetEmpWorkExperienceById(string id)
        {
            try
            {
                var data = await _empWorkExperienceService.GetById(id);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("DeleteEmpWorkExperience")]
        public async Task<IActionResult> DeleteEmpWorkExperience(string id)
        {
            try
            {
                var res = await _empWorkExperienceService.Delete(id);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("UpdateEmpWorkExperience")]
        public async Task<IActionResult> UpdateEmpWorkExperience(WorkExperienceDTO model)
        {
            try
            {
                var res = await _empWorkExperienceService.Update(model);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}
