using Axis.Application.DTOs.HR;
using Axis.Core.Models.HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Application.Services.IServices.HR
{
    public interface IEmpCertificateService
    {
        Task<bool> Add(EmpCertificateDTO model);
        Task<EmpCertificate> Update(EmpCertificateDTO model);
        Task<EmpCertificateDTO> GetById(string id);
        Task<IEnumerable<EmpCertificate>> GetListByComid(string comid);
        Task<bool> Delete(string id);
        (IList<EmpCertificate> data, int total, int totalDisplay) GetListWithCount(string comid, int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false);

    }
}
