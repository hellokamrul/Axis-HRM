using Axis.Application.DTOs.HouseKeeping;
using Axis.Application.Services.IServices.HouseKeeping;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Axis.Api.Controllers
{
   
    public class DesginationController : ApiController
    {
        private readonly IDesignationService _designationService;
        public DesginationController(IDesignationService designationService)
        {
            _designationService = designationService;
        }
        [HttpGet("GetListByComid")]
        public async Task<IActionResult> GetListByComid( string id)
        {
            var data = await _designationService.GetListByComid(id);
            return Ok(data);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var data = await _designationService.GetById(id);
            return Ok(data);
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] DesignationDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var designation = await _designationService.Add(model);
                    return Ok(designation);
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("Error", ex.Message);
                    return BadRequest(ModelState);
                }

            }
            return BadRequest(ModelState);
        }
        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] DesignationDTO data)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var designation = _designationService.Update(data);
                    return Ok(designation);
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("Error", ex.Message);
                    return BadRequest(ModelState);
                }
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            try
            {
                var data = await _designationService.Delete(id);
                return Ok(data);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error", ex.Message);
                return BadRequest(ModelState);
            }
        }
    }
}
