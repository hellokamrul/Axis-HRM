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
    public class FloorService : IFloorService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public FloorService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public Task<bool> Add(FloorDTO floorDTO)
        {
            try
            {
                Floor data = _mapper.Map<Floor>(floorDTO);
                data.Id = Guid.NewGuid().ToString();
                _unitOfWork.Floors.Add(data);
                _unitOfWork.save();
                return Task.FromResult(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding floor: {ex.Message}");
                return Task.FromResult(false);
            }
        }
        public Task<bool> Delete(string id)
        {
            try
            {
                var data = _unitOfWork.Floors.GetById(id);
                if (data != null)
                {
                    _unitOfWork.Floors.Remove(data);
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

        public Task<Floor> GetById(string id)
        {
            try
            {
                return Task.FromResult(_unitOfWork.Floors.GetById(id));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Task.FromResult(new Floor());
            }
        }

        public async Task<IEnumerable<Floor>> GetListByComid(string id)
        {
            try
            {
                var data = _unitOfWork.Floors.GetAll().Where(x => x.ComId == id);
                return await Task.FromResult(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return await Task.FromResult(new List<Floor>());
            }
        }

        public (IList<Floor> data, int total, int totalDisplay) GetPaginatedList(string comid, int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false)
        {
            throw new NotImplementedException();
        }

        public Task<Floor> Update(FloorDTO floorDTO)
        {
            try
            {
                Floor data = _mapper.Map<Floor>(floorDTO);
                _unitOfWork.Floors.Edit(data);
                _unitOfWork.save();
                return Task.FromResult(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Task.FromResult(new Floor());
            }
        }
    
    }
}
