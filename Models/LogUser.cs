using System.ComponentModel.DataAnnotations;

namespace login_n_reg
{
    public class LogUser
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email {get; set;}

        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password {get; set;}
    }
}