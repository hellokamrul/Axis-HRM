using Axis.Application.DTOs.HouseKeeping;
using Axis.Application.DTOs.HR;
using Axis.Core.Models.HouseKeeping;
using Axis.Core.Models.HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Application.Services.IServices.HouseKeeping
{
    public interface IBloodGroupService
    {
        Task<bool> Add(BloodGroupDTO bloodGroupDTO);
        Task<BloodGroup> Update(BloodGroupDTO bloodGroupDTO);
        Task<BloodGroup> GetById(string id);
        Task<IEnumerable<BloodGroup>> GetList();
        Task<bool> Delete(string id);
        (IList<BloodGroup> data, int total, int totalDisplay) GetPaginatedList(string? comid, int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false);

    }
}
