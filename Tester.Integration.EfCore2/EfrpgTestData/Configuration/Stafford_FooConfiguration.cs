// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tester.Integration.EfCore2
{
    // Foo
    public class Stafford_FooConfiguration : IEntityTypeConfiguration<Stafford_Foo>
    {
        public void Configure(EntityTypeBuilder<Stafford_Foo> builder)
        {
            builder.ToTable("Foo", "Stafford");
            builder.HasKey(x => x.Id).HasName("PK_Foo").ForSqlServerIsClustered();

            builder.Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.Name).HasColumnName(@"name").HasColumnType("nchar(10)").IsRequired().IsFixedLength().HasMaxLength(10);

            // Foreign keys
            builder.HasOne(a => a.Stafford_Boo).WithOne(b => b.Stafford_Foo).HasForeignKey<Stafford_Foo>(c => c.Id).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Foo_Boo");
        }
    }

}
// </auto-generated>
