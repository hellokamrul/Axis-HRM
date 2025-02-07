using Axis.Application.DTOs.HR;
using Axis.Core.Models.HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Application.Services.IServices.HR
{
    public interface IEmployeeAddressService
    {
        Task<bool> Add(EmployeeAddressDTO model);
        Task<EmployeeAddress> Update(EmployeeAddressDTO model);
        Task<EmployeeAddressDTO> GetById(string id);
        Task<IEnumerable<EmployeeAddress>> GetListByComid(string comid);
        Task<bool> Delete(string id);
        (IList<EmployeeAddress> data, int total, int totalDisplay) GetListWithCount(string comid, int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false);

    }
}
