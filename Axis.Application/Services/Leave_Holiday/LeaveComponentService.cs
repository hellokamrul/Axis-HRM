using AutoMapper;
using Axis.Application.DTOs.Leave_Holiday;
using Axis.Application.Services.IServices.Holiday_Leave;
using Axis.Core.Models.Leave_Holiday;
using Axis.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Axis.Application.Services.Leave_Holiday
{
    public class LeaveComponentService : ILeaveComponentServe
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public LeaveComponentService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<LeaveComponentDTO> CreateAsync(LeaveComponentDTO dto)
        {         
            var entity = _mapper.Map<LeaveComponent>(dto);
            entity.Id = Guid.NewGuid().ToString();

            await _unitOfWork.LeaveComponent.AddAsync(entity);
            _unitOfWork.save();          

            return _mapper.Map<LeaveComponentDTO>(entity);
        }

        public async Task<LeaveComponentDTO> GetByIdAsync(string id)
        {
            var entity = await _unitOfWork.LeaveComponent.GetByIdAsync(id);
            if (entity == null)
                throw new KeyNotFoundException($"LeaveComponent with Id={id} not found.");

            return _mapper.Map<LeaveComponentDTO>(entity);
        }

        //    public async Task<(IEnumerable<LeaveComponentDTO> Data, int Total)>
        //GetAllAsync(string comid, int pageIndex = 1, int pageSize = 10, bool onlyActive = false)
        //    {
        //        Expression<Func<LeaveComponent, bool>>? filter = onlyActive
        //            ? lc => lc.IsActive
        //            : null;

        //        // 1) fetch the page of data
        //        var entities = await _unitOfWork.LeaveComponent.GetAsync(
        //            filter,
        //            orderBy: q => (IOrderedQueryable<LeaveComponent>)q
        //                                .OrderBy(lc => lc.Name)
        //                                .Skip((pageIndex - 1) * pageSize)
        //                                .Take(pageSize),
        //            include: null,
        //            isTrackingOff: true
        //        );

        //        // 2) get the total count (after filter)
        //        var totalDisplay = await _unitOfWork.LeaveComponent.GetCountAsync(filter);

        //        // 3) map and return
        //        var dtos = entities
        //            .Select(e => _mapper.Map<LeaveComponentDTO>(e))
        //            .ToList();

        //        return (dtos, totalDisplay);
        //    }



        public async Task<(IEnumerable<LeaveComponentDTO> Data, int Total)>
   GetAllAsync(string comid,
               int pageIndex = 1,
               int pageSize = 10,
               bool onlyActive = false)
        {
            // build combined filter
            Expression<Func<LeaveComponent, bool>> filter = lc =>
                lc.ComId == comid &&
                (!onlyActive || lc.IsActive);

            // 1) fetch the page of data
            var entities = await _unitOfWork.LeaveComponent.GetAsync(
                filter: filter,
                orderBy: q => (IOrderedQueryable<LeaveComponent>)q
                                    .OrderBy(lc => lc.Name)
                                    .Skip((pageIndex - 1) * pageSize)
                                    .Take(pageSize),
                include: null,
                isTrackingOff: true
            );

            // 2) get the total count (after filter)
            var total = await _unitOfWork.LeaveComponent.GetCountAsync(filter);

            // 3) map and return
            var dtos = entities
                .Select(e => _mapper.Map<LeaveComponentDTO>(e))
                .ToList();

            return (dtos, total);
        }




        public async Task<LeaveComponentDTO> UpdateAsync(LeaveComponentDTO dto)
        {
            var entity = await _unitOfWork.LeaveComponent.GetByIdAsync(dto.Id);
            if (entity == null)
                throw new KeyNotFoundException($"LeaveComponent with Id={dto.Id} not found.");

            // map changed fields onto the tracked entity
            _mapper.Map(dto, entity);

            _unitOfWork.LeaveComponent.Edit(entity);
            _unitOfWork.save();

            return _mapper.Map<LeaveComponentDTO>(entity);
        }

        public async Task DeleteAsync(string id)
        {
            _unitOfWork.LeaveComponent.Remove(id);
             _unitOfWork.save();
        }
    }
}
