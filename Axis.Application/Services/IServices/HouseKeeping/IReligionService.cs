using Axis.Application.DTOs.HouseKeeping;
using Axis.Core.Models.HouseKeeping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Application.Services.IServices.HouseKeeping
{
    public interface IReligionService
    {
        Task<bool> Add(ReligionDTO religionDTO);
        Task<Religion> Update(ReligionDTO religionDTO);
        Task<Religion> GetById(string id);
        Task<IEnumerable<Religion>> GetList();
        Task<bool> Delete(string id);
        (IList<Religion> data, int total, int totalDisplay) GetPaginatedList(string? comid, int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false);


    }
}
