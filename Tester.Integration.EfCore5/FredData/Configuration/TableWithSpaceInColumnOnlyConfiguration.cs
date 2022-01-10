// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace V5Fred
{
    // TableWithSpaceInColumnOnly
    public class TableWithSpaceInColumnOnlyConfiguration : IEntityTypeConfiguration<TableWithSpaceInColumnOnly>
    {
        public void Configure(EntityTypeBuilder<TableWithSpaceInColumnOnly> builder)
        {
            builder.ToTable("TableWithSpaceInColumnOnly", "dbo");
            builder.HasKey(x => x.IdValue).HasName("PK__TableWit__92CF061C5A0D0BF4").IsClustered();

            builder.Property(x => x.IdValue).HasColumnName(@"id value").HasColumnType("int").IsRequired().ValueGeneratedNever();
        }
    }

}
// </auto-generated>
