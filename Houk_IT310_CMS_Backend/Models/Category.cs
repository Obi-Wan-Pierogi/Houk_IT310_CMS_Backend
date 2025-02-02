namespace Houk_IT310_CMS_Backend.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Content> PostedContent { get; set; }
    }
}