using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AngularDotNetCore.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class AngularDotNetCoreMigrationsDbContextFactory : IDesignTimeDbContextFactory<AngularDotNetCoreMigrationsDbContext>
    {
        public AngularDotNetCoreMigrationsDbContext CreateDbContext(string[] args)
        {
            AngularDotNetCoreEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<AngularDotNetCoreMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new AngularDotNetCoreMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../AngularDotNetCore.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
