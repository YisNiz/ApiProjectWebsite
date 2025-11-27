    using KATSEFET.Modells;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace KATSEFET.Models
{
    public class User
    {

        public int Id { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? Name { get; set; }
        public string? UserName { get; set; }
        public Admin? Admin { get; set; }

        [ForeignKey("Admin")]
       public int AdminId { get; set; }
        public string? Phone { get; set; }
        public ICollection<Order> Orders { get; set; } = new List<Order>();
        public ICollection<Product> Products { get; set; }=new List<Product>();

        
    }
}
