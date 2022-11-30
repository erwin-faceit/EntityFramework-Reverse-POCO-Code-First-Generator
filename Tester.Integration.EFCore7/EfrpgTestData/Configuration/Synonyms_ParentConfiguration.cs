// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace V7EfrpgTest
{
    // Parent
    public class Synonyms_ParentConfiguration : IEntityTypeConfiguration<Synonyms_Parent>
    {
        public void Configure(EntityTypeBuilder<Synonyms_Parent> builder)
        {
            builder.ToTable("Parent", "Synonyms");
            builder.HasKey(x => x.ParentId).HasName("PK_Parent").IsClustered();

            builder.Property(x => x.ParentId).HasColumnName(@"ParentId").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.ParentName).HasColumnName(@"ParentName").HasColumnType("varchar(100)").IsRequired().IsUnicode(false).HasMaxLength(100);
        }
    }

}
// </auto-generated>
