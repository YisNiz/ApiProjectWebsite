using KATSEFET.Modells;
using KATSEFET.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KATSEFET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

         private readonly IProductsService _IProService;


        [HttpGet]
        [Route("GetProductsWithCategoriesDto")]
        public IActionResult GetProductsWithCategoriesDto()
        {
            return Ok(_IProService.GetProductsWithCategoriesDto());
        }


        [HttpGet]
        [Route("getOrderProductDto")]
        public IActionResult getOrderProductDto(string name)
        {
            return Ok(_IProService.getOrderProductDto(name));
        }

        
        [HttpGet]
        [Route("GetSortedProductsDto")]
        public IActionResult GetSortedProductsDto()
        {
            return Ok(_IProService.GetSortedProductsDto());
        }

  
        [HttpPost]
        [Route("CreateProduct")]
        public IActionResult CreateProduct(Product product)
        {
            return Ok(_IProService.CreateProduct(product));
        }


        [HttpPut]
        [Route("{id}/DeleteProduct")]
        public IActionResult SetProductDeleted(int id)
        {
            return Ok(_IProService.SetProductDeleted(id));
        }

  







    }
}
