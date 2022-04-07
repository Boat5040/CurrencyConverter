using System.ComponentModel.DataAnnotations;

namespace CurrencyConverterApp.Models
{
    public class RegistrationViewModel
    {
        [Required]
        [Display(Name = "First Name")]
        public String FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public String LastName{ get; set; }
        [Required]
        [Display(Name = "Email Address")]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public String Password { get; set; }
        [Required]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The new password and confirmation password do not match.")]
        public String ConfirmPassword { get; set; }
    }
}
