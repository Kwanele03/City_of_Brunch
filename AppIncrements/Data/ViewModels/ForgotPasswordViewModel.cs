using System.ComponentModel.DataAnnotations;

namespace AppIncrements.Data.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
