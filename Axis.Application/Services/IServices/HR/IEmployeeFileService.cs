using Axis.Application.DTOs.HR;
using Axis.Core.Models.HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Application.Services.IServices.HR
{
    public interface IEmployeeFileService
    {
        Task<bool> Add(EmployeeFileDTO model);
        Task<EmployeeFile> Update(EmployeeFileDTO model);
        Task<EmployeeFileDTO> GetById(string id);
        Task<IEnumerable<EmployeeFile>> GetListByComid(string comid);
        Task<bool> Delete(string id);
        (IList<EmployeeFile> data, int total, int totalDisplay) GetListWithCount(string comid, int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false);

    }
}
