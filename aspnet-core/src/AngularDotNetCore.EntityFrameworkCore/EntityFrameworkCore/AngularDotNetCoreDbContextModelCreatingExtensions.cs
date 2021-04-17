using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace AngularDotNetCore.EntityFrameworkCore
{
    public static class AngularDotNetCoreDbContextModelCreatingExtensions
    {
        public static void ConfigureAngularDotNetCore(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(AngularDotNetCoreConsts.DbTablePrefix + "YourEntities", AngularDotNetCoreConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}