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
    public class ShiftService : IShiftService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ShiftService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public Task<bool> Add(ShiftDTO shiftDTO)
        {
            try
            {
                Shift data = _mapper.Map<Shift>(shiftDTO);
                data.Id = Guid.NewGuid().ToString();
                _unitOfWork.Shifts.Add(data);
                _unitOfWork.save();
                return Task.FromResult(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding shift: {ex.Message}");
                return Task.FromResult(false);
            }

        }

        public Task<bool> Delete(string id)
        {
            try
            {
                var data = _unitOfWork.Shifts.GetById(id);
                if (data != null)
                {
                    _unitOfWork.Shifts.Remove(data);
                    _unitOfWork.save();
                    return Task.FromResult(true);
                }
                else
                {
                    return Task.FromResult(false);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Task.FromResult(false);
            }
        }

        public Task<Shift> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Shift>> GetListByComid(string id)
        {
            try
            {
                return await Task.FromResult(_unitOfWork.Shifts.GetAll().Where(x => x.ComId == id));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return await Task.FromResult(new List<Shift>().AsEnumerable());
            }
        }
        public (IList<Shift> data, int total, int totalDisplay) GetPaginatedList(string? comid, int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false)
        {
            throw new NotImplementedException();
        }

        public Task<Shift> Update(ShiftDTO shiftDTO)
        {
            try
            {
                Shift data = _mapper.Map<Shift>(shiftDTO);
                _unitOfWork.Shifts.Edit(data);
                _unitOfWork.save();
                return Task.FromResult(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating shift: {ex.Message}");
                return Task.FromResult(new Shift());
            }
        }
    }
}
