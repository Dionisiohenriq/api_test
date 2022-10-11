using api_test.Infra.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_test.DataManager
{
    public abstract class DataManager
    {
        protected readonly ApplicationDbContext _dbContext;
        protected readonly HttpContextAccessor acessor;
        protected readonly IConfiguration Configuration;

        public DataManager()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(AppContext.BaseDirectory))
                .AddJsonFile("appsettings.json", optional: true);

            Configuration = builder.Build();

            var identityContextOptions = new DbContextOptionsBuilder<ApplicationDbContext>();
            identityContextOptions.UseInMemoryDatabase(Configuration.GetConnectionString("DefaultConnection"));

            _dbContext = new ApplicationDbContext(identityContextOptions.Options);
            Seed();
        }
        public abstract void Seed();
    }
}
