using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AngularDotNetCore.Data;
using Volo.Abp.DependencyInjection;

namespace AngularDotNetCore.EntityFrameworkCore
{
    public class EntityFrameworkCoreAngularDotNetCoreDbSchemaMigrator
        : IAngularDotNetCoreDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreAngularDotNetCoreDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the AngularDotNetCoreMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<AngularDotNetCoreMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}