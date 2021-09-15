using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tweetbook.Data;

namespace Tweetbook.Installers
{
    public class MvcInstaller : IInstaller
    {
        public void InstallerServices(IConfiguration configuration, IServiceCollection services)
        {
            services.AddSwaggerGen(Options=>{
                Options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo{
                   Title = "Tweetbook API",Version = "v1" 
                });
            });

            services.AddControllers();
        }
    }
}