using AutoMapper;
using Axis.Application.DTOs.HouseKeeping;
using Axis.Application.Services.IServices.HouseKeeping;
using Axis.Core.Models.HouseKeeping;
using Axis.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Application.Services.HouseKeeping
{
    public class BloodGroupService : IBloodGroupService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public BloodGroupService(IUnitOfWork unitOfWork , IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public async Task<bool> Add(BloodGroupDTO bloodGroupDTO)
        {
            try
            {
                var bloodGroup = _mapper.Map<BloodGroup>(bloodGroupDTO);
                bloodGroup.Id = Guid.NewGuid().ToString();  
                _unitOfWork.BloodGroups.Add(bloodGroup);
                _unitOfWork.save();
                return await Task.FromResult(true);
            }
            catch (Exception ex)
            {
                return await Task.FromResult(false);

            }
        }

        public async Task<bool> Delete(string id)
        {
            try
            {
                var bloodGroup =  _unitOfWork.BloodGroups.GetById(id);
                _unitOfWork.BloodGroups.Remove(bloodGroup);
                _unitOfWork.save();
                return await Task.FromResult(true);
            }
            catch (Exception ex)
            {
                return await Task.FromResult(false);
            }
        }

        public async Task<BloodGroup> GetById(string id)
        {
            try
            {
                var bloodGroup = _unitOfWork.BloodGroups.GetById(id);
                return await Task.FromResult(bloodGroup);
            }
            catch (Exception ex)
            {
                return await Task.FromResult(new BloodGroup());
            }
        }

        public async Task<IEnumerable<BloodGroup>> GetList()
        {
            try
            {
                var bloodGroups = _unitOfWork.BloodGroups.GetAll().ToList();
                return await Task.FromResult(bloodGroups);
            }
            catch (Exception ex)
            {
                return await Task.FromResult(Enumerable.Empty<BloodGroup>());
            }
        }

        public  (IList<BloodGroup> data, int total, int totalDisplay) GetPaginatedList(string? comid, int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false)
        {
            try
            {
                var date =  _unitOfWork.BloodGroups.Get(
                               // filter: e => e.ComId == comid,
                                orderBy: q => q.OrderBy(e => e.Id),
                                pageIndex: pageIndex,
                                pageSize: pageSize
                            );
                return date;
            }
            catch (Exception ex)
            {
                return (new List<BloodGroup>(), 0, 0);
            }
        }

        public async Task<BloodGroup> Update(BloodGroupDTO bloodGroupDTO)
        {
            try
            {
                var bloodGroup = _mapper.Map<BloodGroup>(bloodGroupDTO);
                _unitOfWork.BloodGroups.Edit(bloodGroup);
                _unitOfWork.save();
                return await Task.FromResult(bloodGroup);
            }
            catch (Exception ex)
            {
                return await Task.FromResult(new BloodGroup());
            }
        }
    }
}
