using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCore.Models
{ 
    /// <summary>
    /// Dbcontext for identity
    /// </summary>
    public class UserDbContext : IdentityDbContext<IdentityUser> { 
    
        public UserDbContext(DbContextOptions<UserDbContext> options): base(options)
        {

        }
    }
}