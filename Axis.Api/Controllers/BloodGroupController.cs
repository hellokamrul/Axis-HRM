using AutoMapper;
using Axis.Application.DTOs.HouseKeeping;
using Axis.Application.Services.IServices.HouseKeeping;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Axis.Api.Controllers
{
   
    public class BloodGroupController : ApiController
    {
        private readonly IBloodGroupService _bloodGroupService;
      //  private readonly IMapper _mapper;
        public BloodGroupController(IBloodGroupService bloodGroupService)
        {
            _bloodGroupService = bloodGroupService;
           // _mapper = mapper;
        }
        [HttpPost]
        public async Task<IActionResult> Add(BloodGroupDTO bloodGroupDTO)
        {
            var result = await _bloodGroupService.Add(bloodGroupDTO);
            return Ok(result);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(string id)
        {
            var result = await _bloodGroupService.Delete(id);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetById(string id)
        {
            var result = await _bloodGroupService.GetById(id);
            return Ok(result);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList()
        {
            var result = await _bloodGroupService.GetList();
            return Ok(result);
        }

        [HttpGet("GetPaginatedList")]
        public async Task<IActionResult> GetPaginatedList(string? comid, int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false)
        {
            var result =  _bloodGroupService.GetPaginatedList(comid, pageIndex, pageSize, isTrackingOff);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update(BloodGroupDTO bloodGroupDTO)
        {
            var result = await _bloodGroupService.Update(bloodGroupDTO);
            return Ok(result);
        }
    }
}
