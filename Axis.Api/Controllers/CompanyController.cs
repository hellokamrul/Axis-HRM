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
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
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

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
