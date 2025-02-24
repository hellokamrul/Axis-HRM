using Axis.Application.DTOs.HouseKeeping;
using Axis.Application.Services.IServices.HouseKeeping;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Axis.Api.Controllers
{
    public class FloorController : ApiController
    {
        private readonly IFloorService _floorService;
        public FloorController(IFloorService floorService)
        {
            _floorService = floorService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll(string comid)
        {
            var data = await _floorService.GetListByComid(comid);
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var data = await _floorService.GetById(id);
            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] FloorDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var floor = await _floorService.Add(model);
                    return Ok(floor);
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
        public async Task<IActionResult> Update([FromBody] FloorDTO data)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var floor = await _floorService.Update(data);
                    return Ok(floor);
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
            var data = await _floorService.Delete(id);
            return Ok(data);
        }

    }
}
