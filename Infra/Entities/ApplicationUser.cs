using Microsoft.AspNetCore.Identity;

namespace api_test.Infra.CrossCutting.Identity.Entities
{
    public class ApplicationUser : IdentityUser
    {
        #region Custom properties
        public DateTime CreationDate { get; set; }
        public bool Enabled { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CpfCnpj { get; set; }
        public DateTime DtBirth { get; set; }
        #endregion
    }
}
