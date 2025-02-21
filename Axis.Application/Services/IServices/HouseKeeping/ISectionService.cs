using Axis.Application.DTOs.HouseKeeping;
using Axis.Core.Models.HouseKeeping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Application.Services.IServices.HouseKeeping
{
    public interface ISectionService
    {
        Task<bool> Add(SectionDTO sectionDTO);
        Task<Section> Update(SectionDTO sectionDTO);
        Task<Section> GetById(string id);
        Task<IEnumerable<Section>> GetListByComid(string id);
        Task<bool> Delete(string id);
        (IList<Section> data, int total, int totalDisplay) GetPaginatedList(string? comid, int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false);


    }
}
