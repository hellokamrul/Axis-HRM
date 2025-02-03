using Axis.Application.DTOs;
using Axis.Application.Services.IServices;
using Axis.Core.Models;
using Microsoft.AspNetCore.Mvc;


namespace Axis.Api.Controllers
{
    
    public class CompanyController : ApiController
    {
        private readonly ICompanyService _companyService;
        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            var data = await _companyService.GetCompanies();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var data = await _companyService.GetCompany(id);
            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CompanyDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var company = await _companyService.AddCompany(model);
                    return Ok(company);
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("Error", ex.Message);
                    return BadRequest(ModelState);

                }
                
            }
            return BadRequest(ModelState);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] CompanyDTO data)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var company = _companyService.UpdateCompany(data);
                    return Ok(company);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            try
            {
                var data = _companyService.DeleteCompany(id);
                return Ok(data);
            }
            catch (Exception ex)
            {
                //throw ex;
                return BadRequest(ex.Message);
            }
        }
    }
}
