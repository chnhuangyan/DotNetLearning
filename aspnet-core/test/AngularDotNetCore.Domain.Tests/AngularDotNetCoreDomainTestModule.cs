using AngularDotNetCore.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AngularDotNetCore
{
    [DependsOn(
        typeof(AngularDotNetCoreEntityFrameworkCoreTestModule)
        )]
    public class AngularDotNetCoreDomainTestModule : AbpModule
    {

    }
}