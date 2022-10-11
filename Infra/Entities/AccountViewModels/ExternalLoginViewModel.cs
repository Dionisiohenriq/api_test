using System.ComponentModel.DataAnnotations;

namespace api_test.Infra.CrossCutting.Identity.Entities.AccountViewModels
{
    public class ExternalLoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
