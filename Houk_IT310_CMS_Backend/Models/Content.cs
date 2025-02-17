using Houk_IT310_CMS_Backend.Areas.Identity.Data;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Houk_IT310_CMS_Backend.Models
{
    public class Content
    {
        public int ContentId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public string AuthorId { get; set; }
        public VisibilityStatus Visibility { get; set; }

        [ForeignKey(nameof(Category.CategoryId))]
        public int CategoryId { get; set; }

        // navigation property
        [AllowNull]
        public virtual Category? Category { get; set; }
        public virtual BlogUser Author { get; set; }
    }
}
