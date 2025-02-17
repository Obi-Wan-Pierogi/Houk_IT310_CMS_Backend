
using Houk_IT310_CMS_Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Houk_IT310_CMS_Backend.Data;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Identity;
using Houk_IT310_CMS_Backend.Areas.Identity.Data;

namespace Houk_IT310_CMS_Backend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // link up the database
            builder.Services.AddDbContext<CMS_BackendContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("CMS_BackendContext") 
                    ?? throw new InvalidOperationException("Connection string 'CMS_BackendContext' not found.")));

            // link up the identity, and links to the database
            builder.Services.AddDefaultIdentity<BlogUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<CMS_BackendContext>();

            // Add services to the container.

            builder.Services.AddControllers().AddJsonOptions(options =>
            { 
                options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
                options.JsonSerializerOptions.WriteIndented = true;
            });


            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();
            app.MapRazorPages();

            app.Run();
        }
    }
}
