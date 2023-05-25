using Microsoft.AspNetCore.Mvc;
using masterdata.website.Models;
using masterdata.website.Services.Categories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace masterdata.website.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private readonly ICategoriesService _categoryService;
        public CategoryController(ICategoriesService categoryService)
        {
            _categoryService = categoryService;
        }

        // POST api/<CategorysController>/SearchCategory
        [HttpPost("SearchCategory")]
        public IActionResult SearchCategory(string keyWord, int siteId)
        {
            return Ok(_categoryService.SearchCategory(keyWord, siteId));
        }

        // POST api/<CategorysController>/GetListCategory
        [HttpPost("GetListCategoryBySite")]
        public IActionResult GetListCategoryBySite(int siteId)
        {
            return Ok(_categoryService.GetListCategoryBySite(siteId));
        }

        // GET api/<CategorysController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_categoryService.GetCategory(id));
        }

        // POST api/<CategorysController>
        [HttpPost]
        public IActionResult Post(Category category)
        {
            return Ok(_categoryService.InsertCategory(category));
        }

        // PUT api/<CategorysController>
        [HttpPut("{id}")]
        public IActionResult Put(Category category)
        {
            return Ok(_categoryService.UpdateCategory(category));
        }

        // DELETE api/<CategorysController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_categoryService.DeleteCategory(id));
        }
    }
}
