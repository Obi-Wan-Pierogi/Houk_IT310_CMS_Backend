using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Houk_IT310_CMS_Backend.Models;
using Houk_IT310_CMS_Backend.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Houk_IT310_CMS_Backend.Data
{
    public class CMS_BackendContext : IdentityDbContext<BlogUser>
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

            // add seed data

            // add user data

            // string for the user id

            string userId = "9a4bb6da-00d4-4bb0-adef-61006445fdb5";

            // a variable for the user

            var user = new BlogUser 
            {
                Id = userId,
                Email = "test@test.com",
                NormalizedEmail = "TEST@TEST.COM",
                EmailConfirmed = true,
                UserName = "test@test.com",
                NormalizedUserName = "TEST@TEST.COM",
            };

            // set a password
            PasswordHasher<BlogUser> ph = new PasswordHasher<BlogUser>();
            user.PasswordHash = ph.HashPassword(user, "Password123!");

            // seed user
            modelBuilder.Entity<BlogUser>().HasData(user);

            // add content data
            modelBuilder.Entity<Content>().HasData(
                new Content
                {
                    ContentId = 1,
                    Title = "Toast Post",
                    Body = "It's toasty",
                    AuthorId = userId,
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
                    AuthorId = userId,
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
                    AuthorId = userId,
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
                    AuthorId = userId,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Visibility = VisibilityStatus.Visible,
                    CategoryId = 4
                }
                );

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

            

            modelBuilder.Entity<Content>().Navigation(c => c.Category).AutoInclude();
            modelBuilder.Entity<Category>().Navigation(c => c.PostedContent).AutoInclude();

        }
    }
}
