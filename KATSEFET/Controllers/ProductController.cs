using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using KATSEFET.Modells;

namespace KATSEFET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        //public List<Product> ProductsList = new List<Product>()
        //{
        //    new Product() {ProductId="111",IsDairy=true,IsExist=true,Price=10,Picture="./ice.jpg",Name="iceVanila" },
        //    new Product() {ProductId="111",IsDairy=true,IsExist=true,Price=10,Picture="./ice.jpg",Name="iceVanila",/*TypeOfProduct="2222"*/},
        //    new Product() {ProductId="111",IsDairy=true,IsExist=true,Price=10,Picture="./ice.jpg",Name="iceVanila",/*TypeOfProduct="3333"*/},
        //};

        private readonly ProductsRepository _repository = new();


        [HttpGet]
        [Route("GetCategories")]
        public IActionResult GetProductsWithCategories()
        {
            return Ok(_repository.GetProductsWithCategories());
        }

        [HttpGet]
        [Route("GetProductsWithCategoriesDto")]
        public IActionResult GetProductsWithCategoriesDto()
        {
            return Ok(_repository.GetProductsWithCategoriesDto());
        }
        
        [HttpGet]
        [Route("getOrderProduct")]
        public IActionResult getOrderProduct(string name)
        {
            return Ok(_repository.getOrderProduct(name));
        }


        [HttpGet]
        [Route("getOrderProductDto")]
        public IActionResult getOrderProductDto(string name)
        {
            return Ok(_repository.getOrderProductDto(name));
        }
        

        //[HttpGet]
        //public IActionResult GetProduct()
        //{
        //    return Ok(ProductsList);
        //}

        [HttpGet]
        [Route("GetSortedProducts")]
        public IActionResult GetSortedProducts()
        {
            return Ok(_repository.GetSortedProducts());
        }
        [HttpGet]
        [Route("GetSortedProductsDto")]
        public IActionResult GetSortedProductsDto()
        {
            return Ok(_repository.GetSortedProductsDto());
        }
        
        //[HttpGet("{id}")]
        //public IActionResult GetById(string id)
        //{
        //    Product? product = ProductsList.Find(x => x.ProductId == id);
        //    if (product != null)
        //    {
        //        return Ok(product);
        //    }
        //    else return Ok("not exist");
        //}

        [HttpPost("{product}")]

        public IActionResult CreateProduct(Product product)
        {
            return Ok(_repository.CreateProduct(product));
        }


        //[HttpPut("{id}")]
        //[Route("PutById")]
        //public IActionResult PutById(string id, [FromBody] string Name)
        //{


        //    Product? product = ProductsList.Find(x => x.ProductId == id);
        //    if (product != null)
        //    {
        //        product.Name = Name;
        //        return Ok($"the product with id:{id} updated");
        //    }


        //    else return Ok("not found");
        //}

        [HttpPut]
        [Route("{id}/DeleteProduct")]
        public IActionResult SetProductDeleted(int id)
        {
            return Ok(_repository.SetProductDeleted(id));
        }

        //[HttpGet]
        //[Route("GetPermitRequests")]
        //public IActionResult GetPermitRequests(
        //    [FromQuery] int page,
        //    [FromQuery] int limit)
        //{

        //    var pageData = ProductsList
        //    .Skip((page - 1) * limit)
        //    .Take(limit)
        //    .ToList();

        //    var result = new
        //    {
        //        Data = pageData,
        //        CurrentPage = page,
        //        PageSize = limit,
        //        TotalItems = ProductsList.Count
        //    };
        //    return Ok(result);
        //}







    }
}
