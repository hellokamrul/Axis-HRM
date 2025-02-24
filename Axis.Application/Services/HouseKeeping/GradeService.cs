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
    public class GradeService : IGradeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GradeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public Task<bool> Add(GradeDTO gradeDTO)
        {
            try
            {
                Grade data = _mapper.Map<Grade>(gradeDTO);
                data.Id = Guid.NewGuid().ToString();
                _unitOfWork.Grades.Add(data);
                _unitOfWork.save();
                return Task.FromResult(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding grade: {ex.Message}");
                return Task.FromResult(false);
            }
        }

        public Task<bool> Delete(string id)
        {
            try
            {
                var data = _unitOfWork.Grades.GetById(id);
                if (data != null)
                {
                    _unitOfWork.Grades.Remove(data);
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

        public Task<Grade> GetById(string id)
        {
            try
            {
                return Task.FromResult(_unitOfWork.Grades.GetById(id));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Task.FromResult<Grade>(null);
            }
        }

        public async Task<IEnumerable<Grade>> GetAll()
        {
            try
            {
                return await Task.FromResult(_unitOfWork.Grades.GetAll());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return await Task.FromResult<IEnumerable<Grade>>(null);
            }
        }

        public Task<IEnumerable<Grade>> GetListByComid(string id)
        {
            try
            {
                var data = _unitOfWork.Grades.GetAll().Where(x => x.ComId == id);
                return Task.FromResult(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Task.FromResult<IEnumerable<Grade>>(null);
            }
        }

        public Task<Grade> Update(GradeDTO gradeDTO)
        {
            try
            {
                var data = _unitOfWork.Grades.GetById(gradeDTO.Id);
                if (data != null)
                {
                    data = _mapper.Map<Grade>(gradeDTO);
                    _unitOfWork.Grades.Edit(data);
                    _unitOfWork.save();
                    return Task.FromResult(data);
                }
                else
                {
                    return Task.FromResult<Grade>(null);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating grade: {ex.Message}");
                return Task.FromResult<Grade>(null);
            }
        }

        public (IList<Grade> data, int total, int totalDisplay) GetPaginatedList(string? comid, int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false)
        {
            throw new NotImplementedException();
        }
    }
}
