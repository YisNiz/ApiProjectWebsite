
using KATSEFET.DTO;
using KATSEFET.Modells;
using KATSEFET.Models;
using KATSEFET.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace KATSEFET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController: ControllerBase
    {
        private readonly IProductsService _IProService;


        [HttpGet]
        [Route ("getUsersDto")]
        public IActionResult getUsersDto()
        {
            return Ok(_IProService.GetUsersDtos());
        }

        [HttpPost]
        [Route("createUsersDto")]
        public IActionResult  createUserDto(UserDto user)
        {
            return Ok(_IProService.createUserDto(user));
        }
    }
}
