using api_test.Domain.Entities;
using api_test.Domain.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace apit_test.Api.Controllers
{
    [Route("v1/cartoes")]
    public class VirtualCardController : Controller
    {
        
        private readonly IVirtualCardRepository _repository;

        public VirtualCardController(IServiceProvider serviceProvider)
        {
            _repository = serviceProvider.GetRequiredService<IVirtualCardRepository>();
        }

        [HttpGet]
        [Route("{email}")]
        public VirtualCard GetByEmail(string email)
        {
            return _repository.GetBy(_ => _.Email.Equals(email));
        }
    }
}
