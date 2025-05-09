using Axis.Application.DTOs.Leave_Holiday;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Application.Services.IServices.Holiday_Leave
{
    public interface ILeaveComponentServe
    {
        Task<LeaveComponentDTO> GetByIdAsync(string id);
        Task<(IEnumerable<LeaveComponentDTO> Data, int Total)>
                                 GetAllAsync(string comid, int pageIndex = 1,
                                             int pageSize = 10,
                                             bool onlyActive = false);
        Task<LeaveComponentDTO> CreateAsync(LeaveComponentDTO dto);
        Task<LeaveComponentDTO> UpdateAsync(LeaveComponentDTO dto);
        Task DeleteAsync(string id);
    }
}
