using API_Protect_With_AspNetCore_Identity.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API_Protect_With_AspNetCore_Identity.Models.Services.Infrastructure
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>  
    {  
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)  
        {  
        }  
        
        protected override void OnModelCreating(ModelBuilder builder)  
        {  
            base.OnModelCreating(builder);  
        }  
    } 
}