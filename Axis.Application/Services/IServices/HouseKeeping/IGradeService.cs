using Axis.Application.DTOs.HouseKeeping;
using Axis.Core.Models.HouseKeeping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Application.Services.IServices.HouseKeeping
{
    public interface IGradeService
    {
        Task<bool> Add(GradeDTO gradeDTO);
        Task<Grade> Update(GradeDTO gradeDTO);
        Task<Grade> GetById(string id);
        Task<IEnumerable<Grade>> GetListByComid(string id);
        Task<bool> Delete(string id);
        (IList<Grade> data, int total, int totalDisplay) GetPaginatedList(string? comid, int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false);

    }
}
