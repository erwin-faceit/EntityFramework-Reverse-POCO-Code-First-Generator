// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace V7EfrpgTest
{
    // HasPrincipalKeyTestParent
    public class HasPrincipalKeyTestParentConfiguration : IEntityTypeConfiguration<HasPrincipalKeyTestParent>
    {
        public void Configure(EntityTypeBuilder<HasPrincipalKeyTestParent> builder)
        {
            builder.ToTable("HasPrincipalKeyTestParent", "dbo");
            builder.HasKey(x => x.Id).HasName("PK_HasPrincipalKeyTestParent").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.Aa).HasColumnName(@"AA").HasColumnType("int").IsRequired();
            builder.Property(x => x.Bb).HasColumnName(@"BB").HasColumnType("int").IsRequired();
            builder.Property(x => x.Cc).HasColumnName(@"CC").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.Dd).HasColumnName(@"DD").HasColumnType("int").IsRequired(false);

            builder.HasIndex(x => new { x.Aa, x.Bb }).HasDatabaseName("UQ_HasPrincipalKeyTestParent_AB").IsUnique();
            builder.HasIndex(x => new { x.Aa, x.Cc }).HasDatabaseName("UQ_HasPrincipalKeyTestParent_AC").IsUnique();
            builder.HasIndex(x => new { x.Cc, x.Dd }).HasDatabaseName("UQ_HasPrincipalKeyTestParent_CD").IsUnique();
        }
    }

}
// </auto-generated>
