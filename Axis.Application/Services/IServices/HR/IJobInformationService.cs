using Axis.Application.DTOs.HR;
using Axis.Core.Models.HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Application.Services.IServices.HR
{
    public interface IJobInformationService
    {
        Task<bool> Add(JobInformationDTO model);
        Task<JobInformation> Update(JobInformationDTO model);
        Task<JobInformationDTO> GetById(string id);
        Task<IEnumerable<JobInformation>> GetListByComid(string comid);
        Task<bool> Delete(string id);
        (IList<JobInformation> data, int total, int totalDisplay) GetListWithCount(string comid, int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false);

    }
}
