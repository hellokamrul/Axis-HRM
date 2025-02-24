using Axis.Application.DTOs.HouseKeeping;
using Axis.Application.Services.IServices.HouseKeeping;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Axis.Api.Controllers
{
    public class LineController : ApiController
    {
        private readonly ILineService _lineService;
        public LineController(ILineService lineService)
        {
            _lineService = lineService;
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll(string comid)
        {
            var data = await _lineService.GetListByComid(comid);
            return Ok(data);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDetails(string id)
        {
            var data = await _lineService.GetById(id);
            return Ok(data);
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] LineDTO model)
        {
            if (model != null)
            {
                try
                {
                    //var line = await _lineService.Add(model);
                    return Ok(model);
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
        public async Task<IActionResult> Update([FromBody] LineDTO data)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var line = _lineService.Update(data);
                    return Ok(line);
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
                await _lineService.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error", ex.Message);
                return BadRequest(ModelState);
            }
        }
    }
}
