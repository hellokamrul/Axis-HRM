using Axis.Application.DTOs.HouseKeeping;
using Axis.Application.Services.IServices.HouseKeeping;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Axis.Api.Controllers
{
    public class ShiftController : ApiController
    {
        private readonly IShiftService _shiftService;
        public ShiftController(IShiftService shiftService)
        {
            _shiftService = shiftService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ShiftDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var shift = await _shiftService.Add(model);
                    return Ok(shift);
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
                var shift = await _shiftService.Delete(id);
                return Ok(shift);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error", ex.Message);
                return BadRequest(ModelState);
            }
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get(string comid)
        {
            var data = await _shiftService.GetListByComid(comid);
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDetails(string id)
        {
            var data = await _shiftService.GetById(id);
            return Ok(data);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] ShiftDTO data)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var shift = await _shiftService.Update(data);
                    return Ok(shift);
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("Error", ex.Message);
                    return BadRequest(ModelState);
                }
            }
            return BadRequest(ModelState);
        }





    }
}
