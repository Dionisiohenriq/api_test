using api_test.Domain.Entities.ACL;
using api_test.Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_test.DataManager.Seeds
{
    public class ACLSeeder : SeederBase
    {
        public static void Seed(ApplicationDbContext _dbContext)
        {
            var userRoles = new List<UserRoleVm>()
            {
                new UserRoleVm(Role.ADMIN, ID_USER1,"henrique.qodeless@outlook.com", "1199999-9999", "Henrique", "Qodeless", "282.907.260-07", DateTime.Now),
                new UserRoleVm(Role.USER, ID_USER2, "user@test.com.br", "1199999-9999", "dba", "test", "329.696.620-00", DateTime.Now),
                new UserRoleVm(Role.DBA, ID_USER3, "dba@test.com.br", "1199999-9999", "dba", "test",  "822.774.390-02", DateTime.Now)
            };
            InsertUsers(_dbContext, userRoles);

            var roleClaims = LoadClaimsFromFile(Directory.GetCurrentDirectory());

            InsertRoleClaims(_dbContext, roleClaims);
        }
    }
}
