// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tester.Integration.EfCore3
{
    // table with space and in columns
    public class TableWithSpaceAndInColumnConfiguration : IEntityTypeConfiguration<TableWithSpaceAndInColumn>
    {
        public void Configure(EntityTypeBuilder<TableWithSpaceAndInColumn> builder)
        {
            builder.ToTable("table with space and in columns", "dbo");
            builder.HasKey(x => x.IdValue).HasName("PK__table wi__92CF061C2DBA9525").IsClustered();

            builder.Property(x => x.IdValue).HasColumnName(@"id value").HasColumnType("int").IsRequired().ValueGeneratedNever();
        }
    }

}
// </auto-generated>
