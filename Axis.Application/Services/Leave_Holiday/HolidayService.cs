using AutoMapper;
using Axis.Application.DTOs.Leave_Holiday;
using Axis.Application.Services.IServices.Holiday_Leave;
using Axis.Core.Models.Leave_Holiday;
using Axis.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static Axis.Application.QueryParameter;

namespace Axis.Application.Services.Leave_Holiday
{
    public class HolidayService : IHolidayService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public HolidayService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<HolidayDTO> CreateAsync(HolidayDTO dto)
        {
            var entity = _mapper.Map<Holiday>(dto);

            // 2) Wire up each child’s foreign key to the new parent.Id
            foreach (var child in entity.HolidayLists)
                child.HolidayId = entity.Id;

            await _uow.Holidays.AddAsync(entity);
            _uow.save();
            return _mapper.Map<HolidayDTO>(entity);
        }

        public async Task<HolidayDTO> GetByIdAsync(string id)
        {
            var list = _uow.Holidays.Get(
                filter: h => h.Id == id,
                include: q => q.Include(h => h.HolidayLists)
            );
            var entity = list.FirstOrDefault()
                         ?? throw new KeyNotFoundException($"Holiday '{id}' not found");
            return _mapper.Map<HolidayDTO>(entity);
        }

        public async Task<IEnumerable<HolidayDTO>> GetAllAsync()
        {
            var entities = await _uow.Holidays.GetAllAsync();
            return _mapper.Map<IEnumerable<HolidayDTO>>(entities);
        }

        public Task<PagedResult<HolidayDTO>> GetPagedAsync(HolidayQueryParameters qp)
        {
            // 1) build filter expression
            Expression<Func<Holiday, bool>> filter = h =>
                (qp.OnlyActive == null || h.IsActive == qp.OnlyActive.Value)
             && (string.IsNullOrEmpty(qp.Country) || h.Country == qp.Country)
             && (string.IsNullOrEmpty(qp.Search) || h.Name.Contains(qp.Search));

            // 2) build ordering
            Func<IQueryable<Holiday>, IOrderedQueryable<Holiday>> orderBy = qp.SortBy?.ToLower() switch
            {
                "fromdate" => q => qp.SortDesc ? q.OrderByDescending(h => h.FromDate)
                                               : q.OrderBy(h => h.FromDate),
                "todate" => q => qp.SortDesc ? q.OrderByDescending(h => h.ToDate)
                                               : q.OrderBy(h => h.ToDate),
                _ => q => qp.SortDesc ? q.OrderByDescending(h => h.Name)
                                               : q.OrderBy(h => h.Name),
            };

            // 3) call your synchronous, tuple-returning Get(...)
            var result = _uow.Holidays.Get(
                filter: filter,
                orderBy: orderBy,
                include: q => q.Include(h => h.HolidayLists),
                pageIndex: qp.PageNumber,
                pageSize: qp.PageSize,
                isTrakingOff: true
            );

            // 4) unpack
            var data = result.data;
            var total = result.total;
            var totalDisplay = result.totalDisplay;

            // 5) map and wrap
            var dtoPage = new PagedResult<HolidayDTO>
            {
                Items = _mapper.Map<IEnumerable<HolidayDTO>>(data),
                PageNumber = qp.PageNumber,
                PageSize = qp.PageSize,
                TotalCount = totalDisplay
            };

            return Task.FromResult(dtoPage);
        }

        public async Task<HolidayDTO> UpdateAsync(string id, HolidayDTO dto)
        {
            // load entity
            var existingDto = await GetByIdAsync(id);
            var entity = _mapper.Map<Holiday>(existingDto);

            // apply incoming changes
            _mapper.Map(dto, entity);

            _uow.Holidays.Edit(entity);
            _uow.save();

            return _mapper.Map<HolidayDTO>(entity);
        }

        public Task DeleteAsync(string id)
        {
            // soft-delete
            return UpdateAsync(id, new HolidayDTO { Id = id, IsActive = false });
        }

        //public async Task<IEnumerable<HolidayListDTO>> GetListEntriesAsync(string holidayId)
        //{
        //    var lists = await _uow.HolidayLists.GetAsync(
        //        filter: hl => hl.HolidayId == holidayId
        //    );
        //    return _mapper.Map<IEnumerable<HolidayListDTO>>(lists);
        //}

        public async Task<IEnumerable<HolidayListDTO>> GetListEntriesAsync(string holidayId)
        {
            var lists = await _uow.HolidayLists.GetAsync(
                filter: hl => hl.HolidayId == holidayId,
                orderBy: null,
                include: null,
                isTrackingOff: false
            );

            return _mapper.Map<IEnumerable<HolidayListDTO>>(lists);
        }


        public async Task<HolidayListDTO> AddListEntryAsync(string holidayId, HolidayListDTO dto)
        {
            var entity = _mapper.Map<HolidayList>(dto);
            entity.HolidayId = holidayId;

            await _uow.HolidayLists.AddAsync(entity);
            _uow.save();

            return _mapper.Map<HolidayListDTO>(entity);
        }

        public async Task RemoveListEntryAsync(string listId)
        {
            // load, then remove the entity
            var toRemove = await _uow.HolidayLists.GetByIdAsync(listId);
            if (toRemove == null)
                throw new KeyNotFoundException($"HolidayList entry '{listId}' not found");

            _uow.HolidayLists.Remove(toRemove);
            _uow.save();
        }
    }

}
