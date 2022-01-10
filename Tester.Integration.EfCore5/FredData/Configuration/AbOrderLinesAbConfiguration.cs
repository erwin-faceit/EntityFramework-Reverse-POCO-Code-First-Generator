// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace V5Fred
{
    // AB_OrderLinesAB_
    public class AbOrderLinesAbConfiguration : IEntityTypeConfiguration<AbOrderLinesAb>
    {
        public void Configure(EntityTypeBuilder<AbOrderLinesAb> builder)
        {
            builder.ToTable("AB_OrderLinesAB_", "dbo");
            builder.HasKey(x => x.Id).HasName("PK__AB_Order__3214EC27399A9063").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"ID").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.OrderId).HasColumnName(@"OrderID").HasColumnType("int").IsRequired();
            builder.Property(x => x.Sku).HasColumnName(@"sku").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);

            // Foreign keys
            builder.HasOne(a => a.AbOrdersAb).WithMany(b => b.AbOrderLinesAbs).HasForeignKey(c => c.OrderId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("AB_OrderLinesAB_FK");
        }
    }

}
// </auto-generated>
