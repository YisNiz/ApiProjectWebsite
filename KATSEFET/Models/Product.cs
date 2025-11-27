using KATSEFET.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KATSEFET.Modells
{
    public class Product
    {

        [Required]
        public int ProductId { get; set; }
        public string? Name { get; set; } = string.Empty;
        public string Picture { get; set; }= string.Empty;
        public int Price { get; set; }
        public bool IsDairy { get; set; }
        public bool IsExist { get; set; }
        public Category? TypeOfProduct { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<User> Users { get; set; }= new List<User>();
        public ICollection<Order> Orders { get; set; }= new List<Order>();


    }
}
