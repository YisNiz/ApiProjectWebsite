using KATSEFET.DTO;
using KATSEFET.Modells;
using KATSEFET.Models;

namespace KATSEFET.Repositories
{
    public interface IProductsRepository
    {
        public List<ProductsDto> getOrderProductDto(string name);

        public Product SetProductDeleted(int id);

        public List<ProductsDto> GetProductsWithCategoriesDto();

        public List<OrdersDto> GetOrdersAndProductsDto();

        public List<ProductsDto> GetSortedProductsDto();

        public Product CreateProduct(Product product);

        public int CreateCategoryWithProc(CategoryDto category);

        public bool CreateCategoriesTransaction(List<CategoryDto> list);

        public List<CategoryDto> GetCategories();

        public List<UserDto> GetUsersDtos();


        public User createUserDto(UserDto user);










    }
}
