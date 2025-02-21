using Axis.Application.DTOs.HouseKeeping;
using Axis.Core.Models.HouseKeeping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Application.Services.IServices.HouseKeeping
{
    public interface IDepartmentService
    {
        Task<bool> Add(DepartmentDTO departmentDTO);
        Task<Department> Update(DepartmentDTO departmentDTO);
        Task<Department> GetById(string id);
        Task<IEnumerable<Department>> GetListByComid(string id);
        Task<bool> Delete(string id);
        (IList<Department> data, int total, int totalDisplay) GetPaginatedList(string comid, int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false);

    }
}
