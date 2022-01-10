// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace V6Fred
{
    // Burak2
    public class Burak2Configuration : IEntityTypeConfiguration<Burak2>
    {
        public void Configure(EntityTypeBuilder<Burak2> builder)
        {
            builder.ToTable("Burak2", "dbo");
            builder.HasKey(x => x.Id).HasName("PK_Burak2").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"id").HasColumnType("bigint").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.Num).HasColumnName(@"num").HasColumnType("bigint").IsRequired();

            builder.HasIndex(x => new { x.Id, x.Num }).HasDatabaseName("U_Burak2").IsUnique();
        }
    }

}
// </auto-generated>