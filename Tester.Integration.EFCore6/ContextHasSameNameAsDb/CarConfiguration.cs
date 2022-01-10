// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tester.Integration.EFCore6.ContextHasSameNameAsDb
{
    // Car
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("Car", "dbo");
            builder.HasKey(x => x.Id).HasName("PK__Car__3214EC073A7C141B").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.PrimaryColourId).HasColumnName(@"PrimaryColourId").HasColumnType("int").IsRequired();
            builder.Property(x => x.CarMake).HasColumnName(@"CarMake").HasColumnType("varchar(255)").IsRequired().IsUnicode(false).HasMaxLength(255);
            builder.Property(x => x.ComputedColumn).HasColumnName(@"computed_column").HasColumnType("int").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.ComputedColumnPersisted).HasColumnName(@"computed_column_persisted").HasColumnType("int").IsRequired().ValueGeneratedOnAddOrUpdate();
        }
    }

}
// </auto-generated>
