using System.Threading.Tasks;

namespace AngularDotNetCore.Data
{
    public interface IAngularDotNetCoreDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
