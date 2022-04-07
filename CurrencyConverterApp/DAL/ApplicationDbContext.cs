using CurrencyConverterApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CurrencyConverterApp.DAL
{
    public class ApplicationDbContext:IdentityDbContext<ApplicationUser,ApplicationRole,Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Make sure to call the base method first:

            

            //modelBuilder.Entity<ApplicationUser>().ToTable("User").Property(p => p.Id).HasColumnName("UserId");
            //modelBuilder.Entity<ApplicationUserRole>().ToTable("UserRole");
            //modelBuilder.Entity<ApplicationUserLogin>().ToTable("UserLogin");
            //modelBuilder.Entity<ApplicationUserClaim>().ToTable("UserClaim").Property(p => p.Id).HasColumnName("ClaimId");
            //modelBuilder.Entity<ApplicationRole>().ToTable("Role").Property(p => p.Id).HasColumnName("RoleId");

            base.OnModelCreating(modelBuilder);
        }
    }
}
