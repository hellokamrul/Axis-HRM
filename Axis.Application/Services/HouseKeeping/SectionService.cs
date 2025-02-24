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
    public class SectionService : ISectionService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public SectionService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public Task<bool> Add(SectionDTO sectionDTO)
        {
            try
            {
                Section data = _mapper.Map<Section>(sectionDTO);
                data.Id = Guid.NewGuid().ToString();
                _unitOfWork.Sections.Add(data);
                _unitOfWork.save();
                return Task.FromResult(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding section: {ex.Message}");
                return Task.FromResult(false);
            }
        }


        public Task<bool> Delete(string id)
        {
            try
            {
                var data = _unitOfWork.Sections.GetById(id);
                if (data != null)
                {
                    _unitOfWork.Sections.Remove(data);
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

        public async Task<Section> GetById(string id)
        {
            try
            {
                var data = _unitOfWork.Sections.GetById(id);
                return await Task.FromResult(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<IEnumerable<Section>> GetListByComid(string id)
        {
            try
            {
                return await Task.FromResult(_unitOfWork.Sections.GetAll().Where(x => x.ComId == id).AsEnumerable());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return await Task.FromResult(new List<Section>().AsEnumerable());
            }
        }

        public (IList<Section> data, int total, int totalDisplay) GetPaginatedList(string? comid, int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false)
        {
            throw new NotImplementedException();
        }

        public Task<Section> Update(SectionDTO sectionDTO)
        {
            try
            {
                var data = _mapper.Map<Section>(sectionDTO);
                _unitOfWork.Sections.Edit(data);
                _unitOfWork.save();
                return Task.FromResult(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Task.FromResult(new Section());
            }
        }
    }
}
