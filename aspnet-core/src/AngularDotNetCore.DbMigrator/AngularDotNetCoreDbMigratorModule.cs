using AngularDotNetCore.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AngularDotNetCore.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AngularDotNetCoreEntityFrameworkCoreDbMigrationsModule),
        typeof(AngularDotNetCoreApplicationContractsModule)
        )]
    public class AngularDotNetCoreDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
