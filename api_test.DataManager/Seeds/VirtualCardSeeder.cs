using api_test.Domain.Commands.Inputs;
using api_test.Domain.Entities;
using api_test.Infra.Data;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_test.DataManager.Seeds
{
    public class VirtualCardSeeder
    {
        public static void Seed(ApplicationDbContext _dbContext, HttpContextAccessor accessor)
        {
            Guid card1 = Guid.Parse("5b29fa78-f8bc-4eb3-87ae-2a530d5491b8");
            Guid card2 = Guid.Parse("ee0e1d75-4fd8-4e4f-a2d4-e1cd5ca7d860");
            Guid card3 = Guid.Parse("b3279df6-b36c-45e2-9f21-676207fb996d");

            GenerateVirtualCardCommand cardVal = new GenerateVirtualCardCommand();
            cardVal.Validate("test@test123");

            VirtualCard virtualCards = new List<VirtualCard>()
            {
                
            };

        }

    }
}
