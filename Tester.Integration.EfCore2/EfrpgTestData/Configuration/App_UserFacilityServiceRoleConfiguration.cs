// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tester.Integration.EfCore2
{
    // UserFacilityServiceRole
    public class App_UserFacilityServiceRoleConfiguration : IEntityTypeConfiguration<App_UserFacilityServiceRole>
    {
        public void Configure(EntityTypeBuilder<App_UserFacilityServiceRole> builder)
        {
            builder.ToTable("UserFacilityServiceRole", "App");
            builder.HasKey(x => new { x.UserId, x.AppId, x.FsrId });

            builder.Property(x => x.UserId).HasColumnName(@"userId").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.AppId).HasColumnName(@"appId").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.FsrId).HasColumnName(@"fsrId").HasColumnType("int").IsRequired().ValueGeneratedNever();
        }
    }

}
// </auto-generated>