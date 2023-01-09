using AASA_Back_End.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AASA_Back_End.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        
        }

        public DbSet<Slider> Sliders { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Portfolio> Portfolios { get; set; }

        public DbSet<Setting> Settings { get; set; }

        public DbSet<Employee> Employeees { get; set; }




    }
}
