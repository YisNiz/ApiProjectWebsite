using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

using KATSEFET.Modells;

namespace KATSEFET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController: ControllerBase
    {
        private readonly ProductsRepository _repository = new();

 


        [HttpGet]
        [Route("GetOrdersAndProductsDto")]
        public IActionResult GetOrdersAndProductsDto()
        {
            return Ok(_repository.GetOrdersAndProductsDto());
        }



    }
}
