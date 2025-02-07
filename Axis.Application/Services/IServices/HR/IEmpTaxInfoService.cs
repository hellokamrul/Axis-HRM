using Axis.Application.DTOs.HR;
using Axis.Core.Models.HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Application.Services.IServices.HR
{
    public interface IEmpTaxInfoService
    {
        Task<bool> Add(EmpTaxInfoDTO model);
        Task<EmpTaxInfo> Update(EmpTaxInfoDTO model);
        Task<EmpTaxInfoDTO> GetById(string id);
        Task<IEnumerable<EmpTaxInfo>> GetListByComid(string comid);
        Task<bool> Delete(string id);
        (IList<EmpTaxInfo> data, int total, int totalDisplay) GetListWithCount(string comid, int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false);

    }
}
