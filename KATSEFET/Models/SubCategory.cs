using DocumentFormat.OpenXml.Drawing.Diagrams;

namespace KATSEFET.Models
{
    public class SubCategory
    {

       public required string SubCategoryId { get; set; }
        public string? SubCategoryName { get; set; }
        public Category? BaseCategory { get; set; }
        public ICollection<SubCategory> Childrens { get; set; } = new List<SubCategory>();

    }
}
