using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace Zoo.Place.Installers
{
    public class ViewInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
        }
    }
}
