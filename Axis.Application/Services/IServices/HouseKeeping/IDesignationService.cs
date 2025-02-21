using Axis.Application.DTOs.HouseKeeping;
using Axis.Core.Models.HouseKeeping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Application.Services.IServices.HouseKeeping
{
    public interface IDesignationService 
    {
        Task<bool> Add(DesignationDTO departmentDTO);
        Task<Designation> Update(DesignationDTO departmentDTO);
        Task<Designation> GetById(string id);
        Task<IEnumerable<Designation>> GetListByComid(string id);
        Task<IEnumerable<Designation>> GetListByDeptId(string id);
        Task<bool> Delete(string id);
        (IList<Designation> data, int total, int totalDisplay) GetPaginatedList(string comid, int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false);

    }
}
