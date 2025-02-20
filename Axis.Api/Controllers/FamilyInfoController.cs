using Axis.Application.DTOs.HR;
using Axis.Application.Services.IServices.HR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Axis.Api.Controllers
{
    
    public class FamilyInfoController : ApiController
    {
        private readonly IFamilyService _familyService;
        public FamilyInfoController(IFamilyService familyService)
        {
            _familyService = familyService; 
        }

        [HttpPost]
        public async Task<IActionResult> Create(FamilyInfoDTO model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var response = await _familyService.Add(model);
                    return Ok(response);
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception ex) { 
                return BadRequest(ex); 
            }          
            
        }

        [HttpPut]
        public async Task<IActionResult> Update(FamilyInfoDTO model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var response = await _familyService.Update(model);
                    return Ok(response);
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetFamilyInfoByEmpId(string id)
        {
            try
            {
                var data = await _familyService.GetListByEmpId(id);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
