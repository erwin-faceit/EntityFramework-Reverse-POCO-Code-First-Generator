// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace V6EfrpgTest
{
    // Blarg
    public class BlargConfiguration : IEntityTypeConfiguration<Blarg>
    {
        public void Configure(EntityTypeBuilder<Blarg> builder)
        {
            builder.ToTable("Blarg", "dbo");
            builder.HasKey(x => x.BlargId).HasName("PK_Blarg").IsClustered();

            builder.Property(x => x.BlargId).HasColumnName(@"BlargID").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
        }
    }

}
// </auto-generated>