using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Houk_IT310_CMS_Backend.Models;

namespace Houk_IT310_CMS_Backend.Data
{
    public class CMS_BackendContext : DbContext
    {
        public CMS_BackendContext (DbContextOptions<CMS_BackendContext> options)
            : base(options)
        {
        }

        public DbSet<Houk_IT310_CMS_Backend.Models.Content> Content { get; set; } = default!;
        public DbSet<Houk_IT310_CMS_Backend.Models.Category> Category { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //add seed data
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1,
                    CategoryName = "Food",
                    PostedContent = []
                },
                new Category
                {
                    CategoryId = 2,
                    CategoryName = "Tech",
                    PostedContent = []
                },
                new Category
                {
                    CategoryId = 3,
                    CategoryName = "News",
                    PostedContent = []
                },
                new Category
                {
                CategoryId = 4,
                    CategoryName = "Tacos",
                    PostedContent = []
                }
                );

            modelBuilder.Entity<Content>().HasData(
                new Content
                {
                    ContentId = 1,
                    Title = "Toast Post",
                    Body = "It's toasty",
                    Author = "Lee",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Visibility = VisibilityStatus.Visible,
                    CategoryId = 1
                },
                new Content
                {
                    ContentId = 2,
                    Title = "AI is cool",
                    Body = "And sometimes useful",
                    Author = "Lee",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Visibility = VisibilityStatus.Visible,
                    CategoryId = 2
                },
                new Content
                {
                    ContentId = 3,
                    Title = "Guess What?",
                    Body = "This is my first post.",
                    Author = "Lee",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Visibility = VisibilityStatus.Visible,
                    CategoryId = 3
                },
                new Content
                {
                    ContentId = 4,
                    Title = "Taco Time",
                    Body = "Let's eat tacos",
                    Author = "Lee",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Visibility = VisibilityStatus.Visible,
                    CategoryId = 4
                }
                );

            modelBuilder.Entity<Content>().Navigation(c => c.Category).AutoInclude();
            modelBuilder.Entity<Category>().Navigation(c => c.PostedContent).AutoInclude();

        }
    }
}
