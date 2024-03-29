using System.ComponentModel.DataAnnotations;

namespace login_n_reg
{
    public class RegUser
    {
        [Required]
        [MinLength(2)]
        [Display(Name = "First Name")]
        public string FirstName {get; set;}

        [Required]
        [MinLength(2)]
        [Display(Name = "Last Name")]
        public string LastName {get; set;}

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email {get; set;}

        [Required]
        [DataType(DataType.Password)]
        [MinLength(8)]
        [Display(Name = "Password")]
        public string Password {get; set;}

        [Required]
        [Compare("Password", ErrorMessage="Passwords must match")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword {get; set;}
        

    }
}