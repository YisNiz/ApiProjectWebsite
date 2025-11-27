using KATSEFET.Modells;
using System.ComponentModel.DataAnnotations.Schema;

namespace KATSEFET.Models
{
    public class Order
    {
    public int Id { get; set; }
   
    public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }
    public int TotalPrice { get; set; }
    public ICollection<Product> Products { get; set; } = new List<Product>();

    }
}
