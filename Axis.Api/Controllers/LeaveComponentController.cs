using Axis.Application.DTOs.Leave_Holiday;
using Axis.Application.Services.IServices.Holiday_Leave;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Axis.Api.Controllers
{

    public class LeaveComponentController : ApiController
    {
        private readonly ILeaveComponentServe _leaveComponentService;
        public LeaveComponentController(ILeaveComponentServe leaveComponentService)
        {
            _leaveComponentService = leaveComponentService;
        }

        /// <summary>
        /// GET /api/LeaveComponent
        /// </summary>
        [HttpGet("GetLeaveComponentList")]
        public async Task<IActionResult> GetAll(
     [FromQuery] string comid,
     [FromQuery] int pageIndex = 1,
     [FromQuery] int pageSize = 10,
     [FromQuery] bool onlyActive = false)
        {
            var (items, total) = await _leaveComponentService
                .GetAllAsync(comid, pageIndex, pageSize, onlyActive);

            return Ok(new
            {
                Items = items,
                TotalCount = total,
                PageIndex = pageIndex,
                PageSize = pageSize
            });
        }





        /// <summary>
        /// GET /api/LeaveComponent/{id}
        /// </summary>
        [HttpGet("{id}")]
        public async Task<ActionResult<LeaveComponentDTO>> GetById(string id)
        {
            var dto = await _leaveComponentService.GetByIdAsync(id);
            if (dto == null) return NotFound();
            return Ok(dto);
        }

        /// <summary>
        /// POST /api/LeaveComponent
        /// </summary>
        [HttpPost("CreateLeaveComponent")]
        public async Task<ActionResult<LeaveComponentDTO>> Create([FromBody] LeaveComponentDTO dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var created = await _leaveComponentService.CreateAsync(dto);
            return CreatedAtAction(
                nameof(GetById),
                new { id = created.Id },
                created
            );
        }

        /// <summary>
        /// PUT /api/LeaveComponent/{id}
        /// </summary>
        [HttpPut("{id}")]
        public async Task<ActionResult<LeaveComponentDTO>> Update(string id, [FromBody] LeaveComponentDTO dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (id != dto.Id) return BadRequest("Route id and DTO id must match.");

            var updated = await _leaveComponentService.UpdateAsync(dto);
            return Ok(updated);
        }

        /// <summary>
        /// DELETE /api/LeaveComponent/{id}
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _leaveComponentService.DeleteAsync(id);
            return NoContent();



        }
    }
}
