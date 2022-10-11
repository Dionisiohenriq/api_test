using api_test.Domain.Interfaces;
using api_test.Domain.Interfaces.Repositories;
using api_test.Domain.Repositories;
using api_test.Infra.CrossCutting.Identity.Authorization;
using api_test.Infra.CrossCutting.Identity.Entities;
using api_test.Infra.CrossCutting.Identity.Services;
using api_test.Infra.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;

namespace api_test.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Repositories
            services.AddScoped<IVirtualCardRepository, VirtualCardRepository>();

            // ASP.NET Authorization Polices
            services.AddSingleton<IAuthorizationHandler, ClaimRequirementHandler>();

            // Identity
            services.AddScoped<IUser, AspNetUser>();

            // Infra - Identity Services
            services.AddTransient<IEmailSender, AuthEmailMessageSender>();
            services.AddTransient<ISmsSender, AuthSmsMessageSender>();

            services.AddDbContext<ApplicationDbContext>();
            services.AddSingleton<IAppDbContext, ApplicationDbContext>();

        }
    }
}
