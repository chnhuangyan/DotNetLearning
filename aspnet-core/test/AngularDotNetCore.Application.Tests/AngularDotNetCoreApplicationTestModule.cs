using Volo.Abp.Modularity;

namespace AngularDotNetCore
{
    [DependsOn(
        typeof(AngularDotNetCoreApplicationModule),
        typeof(AngularDotNetCoreDomainTestModule)
        )]
    public class AngularDotNetCoreApplicationTestModule : AbpModule
    {

    }
}