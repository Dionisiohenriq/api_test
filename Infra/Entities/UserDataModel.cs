using api_test.Domain.Entities;
using api_test.Domain.Model;

namespace api_test.Infra.CrossCutting.Identity.DataModel
{
    public class UserDataModel : IUserDataModel
    {
        public string UserId { get; set; }
        public string RoleId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public bool Enabled { get; set; }
        public string CondoId { get; set; }
        public string AssociaationId { get; set; }
        public string BuildingId { get; set; }
        public List<ClaimViewModel> Claims { get; set; } = new List<ClaimViewModel>();
    }
}
