﻿using Axis.Application.DTOs.HR;
using Axis.Core.Models.HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Application.Services.IServices.HR
{
    public interface IFamilyService
    {
        Task<bool> Add(FamilyInfoDTO model);
        Task<FamilyInfo> Update(FamilyInfoDTO model);
        Task<FamilyInfoDTO> GetById(string id);
        Task<IEnumerable<FamilyInfo>> GetListByComid(string comid);
        Task<IEnumerable<FamilyInfo>> GetListByEmpId(string empid);
        Task<bool> Delete(string id);
        (IList<FamilyInfo> data, int total, int totalDisplay) GetListWithCount(string comid, int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false);

    }
}
