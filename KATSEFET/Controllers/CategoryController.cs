using KATSEFET.Data;
using KATSEFET.DTO;
using KATSEFET.DTO;
using KATSEFET.Modells;
using KATSEFET.Modells;
using KATSEFET.Models;
using KATSEFET.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Management.Automation;


namespace KATSEFET.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]

    public class CategoryController:ControllerBase
    {

        private readonly IProductsService _IProService;

        [HttpPost]
        [Route("CreateCategoryWithProc")]
        public IActionResult CreateCategory([FromBody] CategoryDto category)
        {
            try
            {
                int res = _IProService.CreateCategoryWithProc(category);
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
                bool res = _IProService.CreateCategoriesTransaction(list);
                return Ok(res);
        }
            catch (Exception ex)
            {
                Console.WriteLine("failed CreateCategories", ex);
                return BadRequest("Categories not create");
            }

        }
        [HttpGet]
        [Route("GetCategoriesDto")]
        public IActionResult GetCategories()
        {
            return Ok(_IProService.GetCategories());
        }


    }
}
