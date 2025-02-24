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
    public class UnitService : IUnitService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public UnitService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public Task<bool> Add(UnitDTO unitDTO)
        {
            try
            {
                Unit data = _mapper.Map<Unit>(unitDTO);
                data.Id = Guid.NewGuid().ToString();
                _unitOfWork.Units.Add(data);
                _unitOfWork.save();
                return Task.FromResult(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding unit: {ex.Message}");
                return Task.FromResult(false);
            }

        }

        public Task<bool> Delete(string id)
        {
            try
            {
                var data = _unitOfWork.Units.GetById(id);
                if (data != null)
                {
                    _unitOfWork.Units.Remove(data);
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

        public Task<Unit> GetById(string id)
        {
            try
            {
                var data = _unitOfWork.Units.GetById(id);
                return Task.FromResult(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Task.FromResult(new Unit());
            }
        }

        public Task<IEnumerable<Unit>> GetListByComid(string id)
        {
            try
            {
                return Task.FromResult(_unitOfWork.Units.GetAll().Where(x => x.ComId == id).AsEnumerable());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Task.FromResult(new List<Unit>().AsEnumerable());
            }
        }

        public (IList<Unit> data, int total, int totalDisplay) GetPaginatedList(string? comid, int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false)
        {
            throw new NotImplementedException();
        }

        public Task<Unit> Update(UnitDTO unitDTO)
        {
            try
            {
                var data = _mapper.Map<Unit>(unitDTO);
                _unitOfWork.Units.Edit(data);
                _unitOfWork.save();
                return Task.FromResult(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Task.FromResult(new Unit());
            }
        }
    }
}
