using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace CurrencyConverterApp.Models
{
    [Table("User")]
    public class ApplicationUser:IdentityUser<Guid>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime CreatedDate { get; set; }


    }

    [Table("UserLogin")]
    public class ApplicationUserLogin :IdentityUserLogin<string> { }
    [Table("UserClaim")]
    public class ApplicationUserClaim : IdentityUserClaim<string> { }
    [Table("UserRole")]
    public class ApplicationUserRole : IdentityUserRole<string> { }

    [Table("Role")]
    public class ApplicationRole : IdentityRole<Guid> 
    {
        public ApplicationRole() { }
        public ApplicationRole(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }
        public ApplicationRole(string name, string description) 
        {
            Name = name;
            Description = description;
        }
        public string Description { get; set; }

    }

    

    
}
