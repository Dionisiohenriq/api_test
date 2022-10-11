using Microsoft.AspNetCore.Identity;

namespace api_test.Infra.CrossCutting.Identity.Entities.ManagerViewModels
{
    public class ExternalLoginsViewModel
    {
        public IList<UserLoginInfo> CurrentLogins { get; set; }

        public bool ShowRemoveButton { get; set; }

        public string StatusMessage { get; set; }
    }
}
