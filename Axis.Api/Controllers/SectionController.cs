using Axis.Application.DTOs.HouseKeeping;
using Axis.Application.Services.IServices.HouseKeeping;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Axis.Api.Controllers
{
   
    public class SectionController : ApiController
    {
        private readonly ISectionService _sectionService;
        public SectionController(ISectionService sectionService)
        {
            _sectionService = sectionService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get(string comid)
        {
            var data = await _sectionService.GetListByComid(comid);
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDetails(string id)
        {
            var data = await _sectionService.GetById(id);
            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] SectionDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var section = await _sectionService.Add(model);
                    return Ok(section);
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
        public async Task<IActionResult> Update([FromBody] SectionDTO data)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var section = await _sectionService.Update(data);
                    return Ok(section);
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
            var data = await _sectionService.Delete(id);
            return Ok(data);
        }
    }
}
