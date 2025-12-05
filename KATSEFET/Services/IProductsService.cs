using KATSEFET.DTO;
using KATSEFET.Modells;
using KATSEFET.Models;
using System.Management.Automation;

namespace KATSEFET.Services
{
    public interface IProductsService
    {
        public dynamic GetProductsWithCategoriesDto();

        public List<ProductsDto> GetSortedProductsDto();
        public List<ProductsDto> getOrderProductDto(String name);
        public dynamic GetOrdersAndProductsDto();
        public Product SetProductDeleted(int id);
        public Product CreateProduct(Product product);
        public List<CategoryDto> GetCategories();

        public List<UserDto> GetUsersDtos();

        public User createUserDto(UserDto user);

        public int CreateCategoryWithProc(CategoryDto category);

        public bool CreateCategoriesTransaction(List<CategoryDto> list);

    



}
}
