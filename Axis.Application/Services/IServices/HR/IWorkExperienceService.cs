using Axis.Application.DTOs.HR;
using Axis.Core.Models.HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Application.Services.IServices.HR
{
    public interface IWorkExperienceService
    {
        Task<bool> Add(WorkExperienceDTO model);
        Task<WorkExperience> Update(WorkExperienceDTO model);
        Task<WorkExperienceDTO> GetById(string id);
        Task<IEnumerable<WorkExperience>> GetListByComid(string comid);
        Task<bool> Delete(string id);
        (IList<WorkExperience> data, int total, int totalDisplay) GetListWithCount(string comid, int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false);

    }
}
