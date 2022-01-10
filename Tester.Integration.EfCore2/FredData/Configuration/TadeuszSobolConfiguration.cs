// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tester.Integration.EfCore2
{
    // TadeuszSobol
    public class TadeuszSobolConfiguration : IEntityTypeConfiguration<TadeuszSobol>
    {
        public void Configure(EntityTypeBuilder<TadeuszSobol> builder)
        {
            builder.ToTable("TadeuszSobol", "dbo");
            builder.HasKey(x => x.Id).HasName("PK__TadeuszS__3214EC07A9D17117").ForSqlServerIsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseSqlServerIdentityColumn();
            builder.Property(x => x.Description).HasColumnName(@"Description").HasColumnType("varchar(max)").IsRequired(false).IsUnicode(false);
            builder.Property(x => x.Notes).HasColumnName(@"Notes").HasColumnType("nvarchar(max)").IsRequired(false);
            builder.Property(x => x.Name).HasColumnName(@"Name").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
        }
    }

}
// </auto-generated>
