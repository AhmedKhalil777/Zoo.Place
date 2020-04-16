using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zoo.Place.Data;
using Zoo.Place.Services;

namespace Zoo.Place.Installers
{
    public class DataInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ZooDbContext>(options => {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")); 
            });
            services.AddScoped<IZooServices, ZooServices>();
            
        }
    }
}
