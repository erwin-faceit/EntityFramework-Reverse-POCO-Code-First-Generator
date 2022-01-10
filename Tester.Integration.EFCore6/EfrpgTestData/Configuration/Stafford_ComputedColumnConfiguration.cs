// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace V6EfrpgTest
{
    // ComputedColumns
    public class Stafford_ComputedColumnConfiguration : IEntityTypeConfiguration<Stafford_ComputedColumn>
    {
        public void Configure(EntityTypeBuilder<Stafford_ComputedColumn> builder)
        {
            builder.ToTable("ComputedColumns", "Stafford");
            builder.HasKey(x => x.Id).HasName("PK_Stafford_ComputedColumns").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.MyColumn).HasColumnName(@"MyColumn").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.MyComputedColumn).HasColumnName(@"MyComputedColumn").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedOnAddOrUpdate();
        }
    }

}
// </auto-generated>
