using KATSEFET.DTO;
using KATSEFET.Modells;
using KATSEFET.Models;
using KATSEFET.Repositories;
using KATSEFET.Services;
using System;

public class ProductsService: IProductsService
{


    private readonly IProductsRepository _IProRepo;

    public ProductsService(IProductsRepository repo)
    {
        _IProRepo = repo;
    }



    public dynamic GetProductsWithCategoriesDto()
    {
        return _IProRepo.GetProductsWithCategoriesDto();
    }
    
    public List<ProductsDto> GetSortedProductsDto()
    {
        return _IProRepo.GetSortedProductsDto();
    }
    
    public List<ProductsDto> getOrderProductDto(String name)
    {
        return _IProRepo.getOrderProductDto(name);
    }

    public dynamic GetOrdersAndProductsDto()
    {
        return _IProRepo.GetOrdersAndProductsDto();
    }
    public Product SetProductDeleted(int id)
    {
        return _IProRepo.SetProductDeleted(id);
    }
    public Product CreateProduct(Product product)
    {
        return _IProRepo.CreateProduct(product);
    }

    public List<CategoryDto> GetCategories()
    {
        return _IProRepo.GetCategories();
    }

    public List<UserDto> GetUsersDtos()
    {
        return _IProRepo.GetUsersDtos();
    }

    public User createUserDto(UserDto user)
    {
        return _IProRepo.createUserDto(user);
    }

    public int CreateCategoryWithProc(CategoryDto category)
    {
        return _IProRepo.CreateCategoryWithProc(category);
    }

    public bool CreateCategoriesTransaction(List<CategoryDto> list)
    {
        return _IProRepo.CreateCategoriesTransaction(list);
    }

}

