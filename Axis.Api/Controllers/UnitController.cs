using Axis.Application.DTOs.HouseKeeping;
using Axis.Application.Services.IServices.HouseKeeping;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Axis.Api.Controllers
{
    public class UnitController : ApiController
    {
        private readonly IUnitService _unitService;
        public UnitController(IUnitService unitService)
        {
            _unitService = unitService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get(string comid)
        {
            var data = await _unitService.GetListByComid(comid);
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDetails(string id)
        {
            var data = await _unitService.GetById(id);
            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UnitDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var unit = await _unitService.Add(model);
                    return Ok(unit);
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
        public async Task<IActionResult> Update([FromBody] UnitDTO data)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var unit = await _unitService.Update(data);
                    return Ok(unit);
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
            var data = await _unitService.Delete(id);
            return Ok(data);
        }


    }
}
