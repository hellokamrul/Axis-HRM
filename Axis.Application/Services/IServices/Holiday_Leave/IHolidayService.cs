using Axis.Application.DTOs.Leave_Holiday;
using Axis.Core.Models.Leave_Holiday;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Axis.Application.QueryParameter;

namespace Axis.Application.Services.IServices.Holiday_Leave
{
    public interface IHolidayService
    {
        Task<HolidayDTO> CreateAsync(HolidayDTO dto);
        Task<HolidayDTO> GetByIdAsync(string id);
        Task<IEnumerable<HolidayDTO>> GetAllAsync();
        Task<PagedResult<HolidayDTO>> GetPagedAsync(HolidayQueryParameters qp);
        Task<HolidayDTO> UpdateAsync(string id, HolidayDTO dto);
        Task DeleteAsync(string id);

        // if you want to manage individual list‐entries
        Task<IEnumerable<HolidayListDTO>> GetListEntriesAsync(string holidayId);
        Task<HolidayListDTO> AddListEntryAsync(string holidayId, HolidayListDTO dto);
        Task RemoveListEntryAsync(string listId);
    }
}
