
using KATSEFET.DTO;
using KATSEFET.Modells;
using KATSEFET.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace KATSEFET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController: ControllerBase
    {
        private readonly ProductsRepository _repository = new();


        [HttpGet]
        [Route ("getUsersDto")]
        public IActionResult getUsersDto()
        {
            return Ok(_repository.GetUsersDtos());
        }

        [HttpPost]
        [Route("createUsersDto")]
        public IActionResult  createUserDto(UserDto user)
        {
            return Ok(_repository.createUserDto(user));
        }
    }
}
