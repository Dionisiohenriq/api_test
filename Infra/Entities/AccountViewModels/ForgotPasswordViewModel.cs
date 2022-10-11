using System.ComponentModel.DataAnnotations;

namespace api_test.Infra.CrossCutting.Identity.Entities.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
