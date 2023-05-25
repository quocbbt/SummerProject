using Microsoft.AspNetCore.Mvc;
using masterdata.website.Models;
using masterdata.website.Services.Products;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace masterdata.website.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IProductsService _productService;
        public ProductController(IProductsService productService)
        {
            _productService = productService;
        }

        // POST api/<ProductsController>/SearchProduct
        [HttpPost("SearchProduct")]
        public IActionResult SearchProduct(string? keyWord, int categoryId = -1)
        {
            return Ok(_productService.SearchProduct(keyWord, categoryId));
        }

        // POST api/<ProductsController>/GetListProductByListProductId
        [HttpPost("GetListProductByListProductId")]
        public IActionResult GetListProductByListProductId(string listProductId)
        {
            return Ok(_productService.GetListProductByListProductId(listProductId));
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_productService.GetProduct(id));
        }

        // POST api/<ProductsController>
        [HttpPost]
        public IActionResult Post(Product product)
        {
            return Ok(_productService.InsertProduct(product));
        }

        // PUT api/<ProductsController>
        [HttpPut]
        public IActionResult Put(Product product)
        {
            return Ok(_productService.UpdateProduct(product));
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_productService.DeleteProduct(id));
        }
    }
}
