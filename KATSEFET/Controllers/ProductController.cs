using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using KATSEFET.Modells;

namespace KATSEFET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly ProductsRepository _repository = new();




        [HttpGet]
        [Route("GetProductsWithCategoriesDto")]
        public IActionResult GetProductsWithCategoriesDto()
        {
            return Ok(_repository.GetProductsWithCategoriesDto());
        }


        [HttpGet]
        [Route("getOrderProductDto")]
        public IActionResult getOrderProductDto(string name)
        {
            return Ok(_repository.getOrderProductDto(name));
        }

        
        [HttpGet]
        [Route("GetSortedProductsDto")]
        public IActionResult GetSortedProductsDto()
        {
            return Ok(_repository.GetSortedProductsDto());
        }

  
        [HttpPost("{product}")]
        [Route("CreateProduct")]
        public IActionResult CreateProduct(Product product)
        {
            return Ok(_repository.CreateProduct(product));
        }


        [HttpPut]
        [Route("{id}/DeleteProduct")]
        public IActionResult SetProductDeleted(int id)
        {
            return Ok(_repository.SetProductDeleted(id));
        }

  







    }
}
