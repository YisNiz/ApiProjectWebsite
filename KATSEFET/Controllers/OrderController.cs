using KATSEFET.Modells;
using KATSEFET.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace KATSEFET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController: ControllerBase
    {
        private readonly IProductsService _IProService;




        [HttpGet]
        [Route("GetOrdersAndProductsDto")]
        public IActionResult GetOrdersAndProductsDto()
        {
            return Ok(_IProService.GetOrdersAndProductsDto());
        }



    }
}
