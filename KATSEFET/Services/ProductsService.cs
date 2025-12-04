using KATSEFET.DTO;
using KATSEFET.Modells;
using KATSEFET.Models;
using System;

public class ProductsService
{


    private readonly ProductsRepository _repository = new();


    public dynamic GetProductsWithCategoriesDto()
    {
        return _repository.GetProductsWithCategoriesDto();
    }
    
    public List<ProductsDto> GetSortedProductsDto()
    {
        return _repository.GetSortedProductsDto();
    }
    
    public List<ProductsDto> getOrderProductDto(String name)
    {
        return _repository.getOrderProductDto(name);
    }

    public dynamic GetOrdersAndProductsDto()
    {
        return _repository.GetOrdersAndProductsDto();
    }
    public Product SetProductDeleted(int id)
    {
        return _repository.SetProductDeleted(id);
    }
    public Product CreateProduct(Product product)
    {
        return _repository.CreateProduct(product);
    }

    public List<CategoryDto> GetCategories()
    {
        return _repository.GetCategories();
    }

    public List<UserDto> GetUsersDtos()
    {
        return _repository.GetUsersDtos();
    }

    public User createUserDto(UserDto user)
    {
        return _repository.createUserDto(user);
    }
}

