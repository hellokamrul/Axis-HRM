using Axis.Application.DTOs.HR;
using Axis.Core.Models.HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Application.Services.IServices.HR
{
    public interface IBankInfoService
    {
        Task<bool> Add(BankInfoDTO model);
        Task<BankInfo> Update(BankInfoDTO model);
        Task<BankInfoDTO> GetById(string id);
        Task<IEnumerable<BankInfo>> GetListByComid(string comid);
        Task<bool> Delete(string id);
        (IList<BankInfo> data, int total, int totalDisplay) GetListWithCount(string comid, int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false);
    }
}
