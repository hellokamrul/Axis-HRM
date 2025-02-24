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
    public class LineService : ILineService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public LineService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public Task<bool> Add(LineDTO lineDTO)
        {
            try
            {
                Line data = _mapper.Map<Line>(lineDTO);
                data.Id = Guid.NewGuid().ToString();
                _unitOfWork.Lines.Add(data);
                _unitOfWork.save();
                return Task.FromResult(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding line: {ex.Message}");
                return Task.FromResult(false);
            }
        }

        public Task<bool> Add(Line lineDTO)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(string id)
        {
            try
            {
                var data = _unitOfWork.Lines.GetById(id);
                if (data != null)
                {
                    _unitOfWork.Lines.Remove(data);
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

        public Task<Line> GetById(string id)
        {
            try
            {
                return Task.FromResult(_unitOfWork.Lines.GetById(id));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Task.FromResult<Line>(null);
            }
        }

        public async Task<IEnumerable<Line>> GetListByComid(string id)
        {
            try
            {
                return await Task.FromResult(_unitOfWork.Lines.GetAll().Where(x => x.ComId == id).ToList());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Line>();

            }
        }

        public (IList<Line> data, int total, int totalDisplay) GetPaginatedList(string? comid, int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false)
        {
            throw new NotImplementedException();
        }

        public Task<Line> Update(LineDTO lineDTO)
        {
            try
            {
                Line data = _mapper.Map<Line>(lineDTO);
                _unitOfWork.Lines.Edit(data);
                _unitOfWork.save();
                return Task.FromResult(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Task.FromResult<Line>(null);
            }
        }
    }
}
