// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace V7EfrpgTest
{
    // TimestampNullable
    public class TimestampNullableConfiguration : IEntityTypeConfiguration<TimestampNullable>
    {
        public void Configure(EntityTypeBuilder<TimestampNullable> builder)
        {
            builder.ToTable("TimestampNullable", "dbo");
            builder.HasKey(x => x.Id).HasName("PK_TTimestampNullable").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.Version).HasColumnName(@"Version").HasColumnType("timestamp(8)").IsRequired(false).IsFixedLength().HasMaxLength(8).IsRowVersion().IsConcurrencyToken();
            builder.Property(x => x.Number).HasColumnName(@"Number").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>
