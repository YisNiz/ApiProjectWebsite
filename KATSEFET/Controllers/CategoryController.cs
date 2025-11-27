using KATSEFET.Data;
using KATSEFET.DTO;
using KATSEFET.Modells;
using Microsoft.AspNetCore.Mvc;
using System.Management.Automation;

namespace KATSEFET.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]

    public class CategoryController:ControllerBase
    {

        private readonly ProductsRepository _repository = new();

        [HttpPost]
        [Route("CreateCategory")]
        public IActionResult CreateCategory([FromBody] CategoryDto category)
        {
            try
            {
                int res = _repository.CreateCategoryWithProc(category);
                return Ok(res);
            }
            catch (Exception ex)
            {
                 Console.WriteLine("failed CreateCategory", ex);
                return BadRequest("Category not create");
            }

        }


        [HttpPost]
        [Route("CreateCategoriesTransaction")]
        public IActionResult CreateCategories([FromBody] List<CategoryDto> list)
        {
            try
            {
                bool res = _repository.CreateCategoriesTransaction(list);
                return Ok(res);
        }
            catch (Exception ex)
            {
                Console.WriteLine("failed CreateCategories", ex);
                return BadRequest("Categories not create");
            }

        }
}
}
