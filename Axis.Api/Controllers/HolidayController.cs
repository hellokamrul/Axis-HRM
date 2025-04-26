using Axis.Application.DTOs.Leave_Holiday;
using Axis.Application.Services.IServices.Holiday_Leave;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Axis.Application.QueryParameter;

namespace Axis.Api.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class HolidayController : ApiController
    {
        private readonly IHolidayService _holidayService;

        public HolidayController(IHolidayService holidayService)
        {
            _holidayService = holidayService;
        }

        // GET api/holidays
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HolidayDTO>>> GetAll()
        {
            var holidays = await _holidayService.GetAllAsync();
            return Ok(holidays);
        }

        // GET api/holidays/{id}
        [HttpGet("{id}", Name = "GetHolidayById")]
        public async Task<ActionResult<HolidayDTO>> GetById(string id)
        {
            var holiday = await _holidayService.GetByIdAsync(id);
            return Ok(holiday);
        }

        // GET api/holidays/paged?PageNumber=1&PageSize=10&Search=foo&Country=US&OnlyActive=true&SortBy=fromDate&SortDesc=false
        [HttpGet("paged")]
        public async Task<ActionResult<PagedResult<HolidayDTO>>> GetPaged([FromQuery] HolidayQueryParameters qp)
        {
            var page = await _holidayService.GetPagedAsync(qp);
            return Ok(page);
        }

        // POST api/holidays
        [HttpPost]
        public async Task<ActionResult<HolidayDTO>> Create([FromBody] HolidayDTO dto)
        {
            var created = await _holidayService.CreateAsync(dto);
            return CreatedAtRoute("GetHolidayById", new { id = created.Id }, created);
        }

        // PUT api/holidays/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult<HolidayDTO>> Update(string id, [FromBody] HolidayDTO dto)
        {
            if (id != dto.Id)
                return BadRequest("ID in URL must match ID in payload.");

            var updated = await _holidayService.UpdateAsync(id, dto);
            return Ok(updated);
        }

        // DELETE api/holidays/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _holidayService.DeleteAsync(id);
            return NoContent();
        }

        // GET api/holidays/{id}/entries
        [HttpGet("{id}/entries")]
        public async Task<ActionResult<IEnumerable<HolidayListDTO>>> GetEntries(string id)
        {
            var entries = await _holidayService.GetListEntriesAsync(id);
            return Ok(entries);
        }

        // POST api/holidays/{id}/entries
        [HttpPost("{id}/entries")]
        public async Task<ActionResult<HolidayListDTO>> AddEntry(string id, [FromBody] HolidayListDTO dto)
        {
            var added = await _holidayService.AddListEntryAsync(id, dto);
            return CreatedAtAction(
                nameof(GetEntries),
                new { id = id },
                added
            );
        }

        // DELETE api/holidays/entries/{listId}
        [HttpDelete("entries/{listId}")]
        public async Task<IActionResult> DeleteEntry(int listId)
        {
            // service expects a string id, so convert
            await _holidayService.RemoveListEntryAsync(listId.ToString());
            return NoContent();
        }
    }
}
