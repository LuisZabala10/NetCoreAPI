using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Tweetbook
{
    public interface IInstaller
    {
        void InstallerServices(IConfiguration configuration,IServiceCollection services);
    }
}