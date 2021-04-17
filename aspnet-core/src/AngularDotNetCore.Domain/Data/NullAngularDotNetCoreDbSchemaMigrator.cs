using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AngularDotNetCore.Data
{
    /* This is used if database provider does't define
     * IAngularDotNetCoreDbSchemaMigrator implementation.
     */
    public class NullAngularDotNetCoreDbSchemaMigrator : IAngularDotNetCoreDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}