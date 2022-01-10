// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tester.Integration.EfCore3
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

            builder.HasIndex(x => new { x.Aa, x.Bb }).HasName("UQ_HasPrincipalKeyTestParent_AB").IsUnique();
            builder.HasIndex(x => new { x.Aa, x.Cc }).HasName("UQ_HasPrincipalKeyTestParent_AC").IsUnique();
            builder.HasIndex(x => new { x.Cc, x.Dd }).HasName("UQ_HasPrincipalKeyTestParent_CD").IsUnique();
        }
    }

}
// </auto-generated>
