using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Houk_IT310_CMS_Backend.Models;
using Microsoft.AspNetCore.Identity;

namespace Houk_IT310_CMS_Backend.Areas.Identity.Data;

// Add profile data for application users by adding properties to the BlogUser class
public class BlogUser : IdentityUser
{
    public virtual ICollection<Content> Posts { get; set; }

}

