using api_test.Domain.Entities;
using api_test.Domain.Interfaces.Repositories;
using api_test.Infra.CrossCutting.Identity.Repositories;
using api_test.Infra.Data;
using Microsoft.AspNetCore.Http;

namespace api_test.Domain.Repositories
{
    public class VirtualCardRepository : Repository<VirtualCard>, IVirtualCardRepository
    {
        public VirtualCardRepository(ApplicationDbContext context, IHttpContextAccessor accessor) : base(context, accessor)
        {

        }
    }
}
