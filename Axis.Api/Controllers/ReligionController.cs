using Axis.Application.DTOs.HouseKeeping;
using Axis.Application.Services.IServices.HouseKeeping;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Axis.Api.Controllers
{
    
    public class ReligionController : ApiController
    {
        private readonly IReligionService _religionService;
        public ReligionController(IReligionService religionService)
        {
            _religionService = religionService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            var data = await _religionService.GetList();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDetails(string id)
        {
            var data = await _religionService.GetById(id);
            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ReligionDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var religion = await _religionService.Add(model);
                    return Ok(religion);
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
        public async Task<IActionResult> Update([FromBody] ReligionDTO data)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var religion = await _religionService.Update(data);
                    return Ok(religion);
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
            var data = await _religionService.Delete(id);
            return Ok(data);
        }

    }
}
