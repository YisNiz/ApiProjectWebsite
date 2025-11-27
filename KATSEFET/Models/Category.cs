using KATSEFET.Models;
using System.ComponentModel.DataAnnotations;

namespace KATSEFET.Modells
{
    public class Category
    {
        [MinLength(3)]
        public string? CategoryName { get; set; } = string.Empty;
        public string? Description { get; set; }
        [Key]
        public int? CategoryId { get; set; }
        public ICollection<Product>? Products { get; set; }=new List<Product>();


    }
                       
                       

        
}





   



