using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace AngularDotNetCore.EntityFrameworkCore
{
    [DependsOn(
        typeof(AngularDotNetCoreEntityFrameworkCoreModule)
        )]
    public class AngularDotNetCoreEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<AngularDotNetCoreMigrationsDbContext>();
        }
    }
}
