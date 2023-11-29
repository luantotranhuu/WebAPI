using huuluan.Domain.Models;
using huuluan.Domain.Repositories;
using huuluan.Domain.Services;
using huuluan.DTO;
using huuluan.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace huuluan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public List<CategoryViewModel> GetAll()
        {
            return _categoryService.GetAll();
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public Category GetById([FromRoute] int id) 
        {
            return _categoryService.GetById(id);
        }
        [HttpPost]
        public IActionResult PostCategory([FromBody] CategoryDTO categoryDTO) 
        {
            try 
            {
                return Ok(_categoryService.PostCategory(categoryDTO));
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        [Route("DeleteById/{id}")]
        public Category DeleteById(int id) 
        {
            return _categoryService.DeleteById(id);
        }
        [HttpPut]
        [Route("{id}")]
        public Category UpdateCat( [FromRoute] int id,[FromBody]CategoryDTO categoryDTO) 
        {
            return _categoryService.UpdateCat(id, categoryDTO);
        }
    }
}
