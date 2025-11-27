
using KATSEFET.Modells;

namespace KATSEFET.Models
{
    public class Admin
    {
      
        public  int AdminId { get; set; }
        public string AdminName { get; set; } = string.Empty;
        public ICollection<User> Users { get; set; } = new List<User>();





    }
}
