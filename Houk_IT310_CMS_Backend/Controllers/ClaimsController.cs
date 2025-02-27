using Houk_IT310_CMS_Backend.Areas.Identity.Data;
using Houk_IT310_CMS_Backend.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Houk_IT310_CMS_Backend.Controllers
{
    public class Taco 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimsController : ControllerBase
    {        
        private readonly CMS_BackendContext _context;
        private readonly UserManager<BlogUser> _userManager;
        private List<Taco> _tacoList;       

        public ClaimsController(CMS_BackendContext ctx, UserManager<BlogUser> usr) {
            // bind context and services for use in the controller
            _context = ctx;
            _userManager = usr;

            _tacoList = new List<Taco> {
                new Taco { Id = 1, Name = "Soft Taco", Price = 0.99f },
                new Taco { Id = 2, Name = "Hard Taco", Price = 0.89f },
                new Taco { Id = 3, Name = "Fish Taco", Price = 2.99f },
                new Taco { Id = 4, Name = "Shrimp Taco", Price = 2.99f }
            };
        }

        // our endpoint function for getting all claims
        [HttpGet]
        public async Task<ActionResult<ClaimsPrincipal>> Get() 
        {           
            return User;
        }
    }
}
