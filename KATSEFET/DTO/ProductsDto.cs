using DocumentFormat.OpenXml.Drawing.Diagrams;
using KATSEFET.Modells;
using KATSEFET.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KATSEFET.DTO
{
    public class ProductsDto
    {

        public string? Name { get; set; } = string.Empty;
        public string? TypeOfProduct { get; set; }
        public bool IsDeleted { get; set; }
    }

    public class OrdersDto
    {
        public string? User { get; set; }
        public int TotalPrice { get; set; }
        public ICollection<ProductsDto> Products { get; set; } = new List<ProductsDto>();
    }

    public class CategoryDto
    {
        public string? CategoryName { get; set; } = string.Empty;
        public string? Description { get; set; }

    }

    public class UserDto
    {
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? Name { get; set; }
        public string? UserName { get; set; }
        public Admin? Admin { get; set; }
        public string? Phone { get; set; }
    }

}
