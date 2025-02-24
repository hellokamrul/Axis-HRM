using Axis.Application.DTOs.HouseKeeping;
using Axis.Application.Services.IServices.HouseKeeping;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Axis.Api.Controllers
{
    public class DepartmentController : ApiController
    {
        private readonly IDepartmentService _departmentService;
        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }
       
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var data = await _departmentService.GetById(id);
            return Ok(data);
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] DepartmentDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var department = await _departmentService.Add(model);
                    return Ok(department);
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
        public async Task<IActionResult> Update([FromBody] DepartmentDTO data)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var department = _departmentService.Update(data);
                    return Ok(department);
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
                await _departmentService.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error", ex.Message);
                return BadRequest(ModelState);
            }
        }

        [HttpGet("GetListByComid")]
        public async Task<IActionResult> GetListByComid( string id)
        {
            var data = await _departmentService.GetListByComid(id);
            return Ok(data);
        }
    }
}
