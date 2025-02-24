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
    public class ReligionService : IReligionService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ReligionService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public Task<bool> Add(ReligionDTO religionDTO)
        {
            try
            {
                Religion data = _mapper.Map<Religion>(religionDTO);
                data.Id = Guid.NewGuid().ToString();
                _unitOfWork.Religions.Add(data);
                _unitOfWork.save();
                return Task.FromResult(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding religion: {ex.Message}");
                return Task.FromResult(false);
            }
        }

        public async Task<bool> Delete(string id)
        {
            try
            {
                var data = _unitOfWork.Religions.GetById(id);
                if (data != null)
                {
                    _unitOfWork.Religions.Remove(data);
                    _unitOfWork.save();
                    return await Task.FromResult(true);
                }
                else
                {
                    return await Task.FromResult(false);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return await Task.FromResult(false);
            }
        }

        public async Task<Religion> GetById(string id)
        {
            try
            {
                var data = _unitOfWork.Religions.GetById(id);
                return await Task.FromResult(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<IEnumerable<Religion>> GetAll()
        {
            try
            {
                return await Task.FromResult(_unitOfWork.Religions.GetAll());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return await Task.FromResult<IEnumerable<Religion>>(null);
            }
        }


        public async Task<IEnumerable<Religion>> GetListByComid(string id)
        {
            try
            {
                return await Task.FromResult(_unitOfWork.Religions.GetAll().Where(x => x.ComId == id).ToList());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return await Task.FromResult(new List<Religion>());
            }
        }

        public async Task<Religion> Update(ReligionDTO religionDTO)
        {
            try
            {
                var data =  _unitOfWork.Religions.GetById(religionDTO.Id);
                if (data != null)
                {
                    var religionData = _mapper.Map<Religion>(religionDTO);
                    //data.Name = religionDTO.Name;
                    //data.Description = religionDTO.Description;
                    //data.ComId = religionDTO.ComId;
                    _unitOfWork.Religions.Edit(religionData);
                    _unitOfWork.save();
                    return await Task.FromResult(religionData);
                }
                else
                {
                    return await Task.FromResult(new Religion());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return await Task.FromResult(new Religion());
            }
        }
        public async Task<IEnumerable<Religion>> GetList()
        {
            try
            {
                var data = _unitOfWork.Religions.GetAll();
                return await Task.FromResult(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return await Task.FromResult<IEnumerable<Religion>>(null);
            }
        }

        public (IList<Religion> data, int total, int totalDisplay) GetPaginatedList(string? comid, int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false)
        {
            throw new NotImplementedException();
        }
    }
}
