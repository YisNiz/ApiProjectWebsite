using KATSEFET.DTO;
using KATSEFET.Modells;
using System;

public class ProductsService
{


    private readonly ProductsRepository _repository = new();

    public dynamic GetProductsWithCategories()
    {
        return _repository.GetProductsWithCategories();
    }
    public dynamic GetProductsWithCategoriesDto()
    {
        return _repository.GetProductsWithCategoriesDto();
    }
    

    public List<Product> GetSortedProducts()
    {
        return _repository.GetSortedProducts();
    }
    public List<ProductsDto> GetSortedProductsDto()
    {
        return _repository.GetSortedProductsDto();
    }
    

    public List<Product> GetOrderProduct(String name)
    {
        return _repository.getOrderProduct(name);
    }

    public List<ProductsDto> getOrderProductDto(String name)
    {
        return _repository.getOrderProductDto(name);
    }
    
    public dynamic GetOrdersAndProducts()
    {
        return _repository.GetOrdersAndProducts();
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
}

