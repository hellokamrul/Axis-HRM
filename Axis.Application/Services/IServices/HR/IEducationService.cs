using Axis.Application.DTOs.HR;
using Axis.Core.Models.HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Application.Services.IServices.HR
{
    public interface IEducationService
    {
        Task<bool> Add(EducationDTO model);
        Task<Education> Update(EducationDTO model);
        Task<EducationDTO> GetById(string id);
        Task<IEnumerable<Education>> GetListByComid(string comid);
        Task<bool> Delete(string id);
        (IList<Education> data, int total, int totalDisplay) GetListWithCount(string comid, int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false);


    }
}
