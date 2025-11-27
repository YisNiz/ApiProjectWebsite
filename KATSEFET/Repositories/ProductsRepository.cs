using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Wordprocessing;
using KATSEFET.Data;
using KATSEFET.DTO;
using KATSEFET.Modells;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using OpenXmlPowerTools;
using System;
using System.Linq;
using System.Net;
using Category = KATSEFET.Modells.Category;

public class ProductsRepository
{

    KATSEFETContext context = KatsefetContextFactory.CreateContext();

    public List<Product> getOrderProduct(string name)
    {
        var ProductsTags = context.Products.
            Where(c => (c.TypeOfProduct.CategoryName == name) & (c.IsDeleted == false))
            .ToList();
        return ProductsTags;
    }
    public List<ProductsDto> getOrderProductDto(string name)
    {
        return context.Products
       .Where(c => c.TypeOfProduct.CategoryName == name)
       .Select(p => new ProductsDto
       {
           Name = p.Name,
           IsDeleted = p.IsDeleted,
           TypeOfProduct = p.TypeOfProduct.CategoryName
       }).ToList();
    }


    public Product SetProductDeleted(int id)
    {
        var ProductsTags = context.Products.
            Where(c => c.ProductId == id)
            .ToList();
        ProductsTags[0].IsDeleted = true;
        context.SaveChanges();
        return ProductsTags[0];

    }
    public dynamic GetProductsWithCategories()
    {
        var ProductsTags = context.Products
                .Include(x => x.TypeOfProduct)
                .Where(a => a.IsDeleted == false)
                .Select(a => new
                {
                    a.Name,
                    categories = a.TypeOfProduct.CategoryName
                })
                .ToList();
        return ProductsTags;
    }
    public List<ProductsDto> GetProductsWithCategoriesDto()
    {
        var Products = context.Products
                .Include(x => x.TypeOfProduct)
                .Where(a => a.IsDeleted == false)
                .Select(a => new ProductsDto
                {
                    Name = a.Name,
                    IsDeleted = a.IsDeleted,
                    TypeOfProduct = a.TypeOfProduct.CategoryName
                })
                .ToList();
        return Products;
    }

    public dynamic GetOrdersAndProducts()
    {
        var OrdersTag = context.Orders
        .Include(x => x.Products)
        .Select(a => new
        {
            a.User.Name,
            Products = a.Products.Select(c => c.Name)
        }).ToList();

        return OrdersTag;
    }
    public List<OrdersDto> GetOrdersAndProductsDto()
    {
        var Orders = context.Orders
        .Include(x => x.Products)
        .Select(a => new OrdersDto
        {
            User = a.User.Name,
            TotalPrice = a.TotalPrice,
            Products = a.Products
                .Select(p => new ProductsDto
                {
                    Name = p.Name,
                    IsDeleted = p.IsDeleted,
                    TypeOfProduct = p.TypeOfProduct.CategoryName
                })
                .ToList()
        }).ToList();

        return Orders;
    }

    public List<Product> GetSortedProducts()
    {
        var ProductsTags = context.Products
            .Where(a => a.IsDeleted == false)
                .OrderBy(x => x.Name)
               .ToList();
        return ProductsTags;
    }
    public List<ProductsDto> GetSortedProductsDto()
    {
        var Products = context.Products
            .Where(a => a.IsDeleted == false)
            .Select(p => new ProductsDto
            {
                Name = p.Name,
                IsDeleted = p.IsDeleted,
            })
             .OrderBy(x => x.Name)
             .ToList();
        return Products;
    }


    public Product CreateProduct(Product product)
    {
        context.Products.Add(product);
        context.SaveChanges();
        return product;
    }

    public int CreateCategoryWithProc(CategoryDto category)
    {
        var outputParam = new SqlParameter
        {
            ParameterName = "@CategoryId",
            SqlDbType = System.Data.SqlDbType.Int,
            Direction = System.Data.ParameterDirection.Output
        };

        var parameters = new[]
        {
                new SqlParameter("@CategoryName", category.CategoryName),
                new SqlParameter("@Description", category.Description),
                outputParam
             };


        context.Database.ExecuteSqlRaw(
        "EXEC CreateCategory  @Description,@CategoryName, @CategoryId OUTPUT",
        parameters);

        // Get the output value
        int newCategoryId = (int)outputParam.Value;


        return newCategoryId;
    }

    public bool CreateCategoriesTransaction(List<CategoryDto> list)
    {
        using var transaction = context.Database.BeginTransaction();
        try
        {
            foreach (var category in list)
            {
                CreateCategoryWithProc(category);
            }
            transaction.Commit();
            return true;
        }
        catch
        {
            transaction.Rollback();
            return false;
        }
    }
}








