using Axis.Application.DTOs.HouseKeeping;
using Axis.Application.Services.IServices.HouseKeeping;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Axis.Api.Controllers
{
    public class GradeController : ApiController
    {
        private readonly IGradeService _gradeService;
        public GradeController(IGradeService gradeService)
        {
            _gradeService = gradeService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get( string comid)
        {
            var data = await _gradeService.GetListByComid(comid);
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDetails(string id)
        {
            var data = await _gradeService.GetById(id);
            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] GradeDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var grade = await _gradeService.Add(model);
                    return Ok(grade);
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
        public async Task<IActionResult> Update([FromBody] GradeDTO data)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var grade = await _gradeService.Update(data);
                    return Ok(grade);
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
            var data = await _gradeService.Delete(id);
            return Ok(data);
        }

    }

}
