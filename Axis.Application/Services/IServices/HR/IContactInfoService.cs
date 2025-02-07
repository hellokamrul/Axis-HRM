using Axis.Application.DTOs.HR;
using Axis.Core.Models.HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Application.Services.IServices.HR
{
    public interface IContactInfoService
    {
        Task<bool> Add(ContactInfoDTO model);
        Task<ContactInfo> Update(ContactInfoDTO model);
        Task<ContactInfoDTO> GetById(string id);
        Task<IEnumerable<ContactInfo>> GetListByComid(string comid);
        Task<bool> Delete(string id);
        (IList<ContactInfo> data, int total, int totalDisplay) GetListWithCount(string comid, int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false);

    }
}
