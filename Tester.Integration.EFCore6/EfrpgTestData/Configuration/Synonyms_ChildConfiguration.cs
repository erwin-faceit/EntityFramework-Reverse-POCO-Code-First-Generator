// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace V6EfrpgTest
{
    // Child
    public class Synonyms_ChildConfiguration : IEntityTypeConfiguration<Synonyms_Child>
    {
        public void Configure(EntityTypeBuilder<Synonyms_Child> builder)
        {
            builder.ToTable("Child", "Synonyms");
            builder.HasKey(x => x.ChildId).HasName("PK_Child").IsClustered();

            builder.Property(x => x.ChildId).HasColumnName(@"ChildId").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.ParentId).HasColumnName(@"ParentId").HasColumnType("int").IsRequired();
            builder.Property(x => x.ChildName).HasColumnName(@"ChildName").HasColumnType("varchar(100)").IsRequired(false).IsUnicode(false).HasMaxLength(100);

            // Foreign keys
            builder.HasOne(a => a.Synonyms_Parent).WithMany(b => b.Synonyms_Children).HasForeignKey(c => c.ParentId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Child_Parent");
        }
    }

}
// </auto-generated>
