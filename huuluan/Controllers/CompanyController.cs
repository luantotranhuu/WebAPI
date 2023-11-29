using AutoMapper;
using huuluan.Domain.Models;
using huuluan.Domain.Services;
using huuluan.DTO;
using huuluan.Services;
using huuluan.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace huuluan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private ICompanyService _companyService;
        private readonly IMapper _mapper;

        public CompanyController(ICompanyService companyService, IMapper mapper)
        {
            _companyService = companyService;
            _mapper = mapper;
        }
        
        [HttpGet]
        [Route("GetAll")]
        public List<CompanyViewModel> GetAll()
        {
            return  _companyService.GetAll();
        }
        [HttpPost]
        public IActionResult PostCompany([FromBody] CompanyDTO companyDTO)
        {
            try
            {
                return Ok(_companyService.PostCompany(companyDTO));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public Company GetById([FromRoute] int id)
        {
            return _companyService.GetById(id);
        }
        [HttpDelete]
        [Route("DeleteById/{id}")]
        public Company DeleteById(int id)
        {
            return _companyService.DeleteById(id);
        }
        [HttpPut]
        [Route("{id}")]
        public Company UpdateCom([FromRoute] int id, [FromBody] CompanyDTO companyDTO)
        {
            return _companyService.UpdateCom(id, companyDTO);
        }

    }
}
