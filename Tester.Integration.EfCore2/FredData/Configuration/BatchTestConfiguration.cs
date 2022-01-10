// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tester.Integration.EfCore2
{
    // BatchTest
    public class BatchTestConfiguration : IEntityTypeConfiguration<BatchTest>
    {
        public void Configure(EntityTypeBuilder<BatchTest> builder)
        {
            builder.ToTable("BatchTest", "dbo");
            builder.HasKey(x => x.Code).HasName("PK__BatchTes__357D4CF8B8A16F6F").ForSqlServerIsClustered();

            builder.Property(x => x.Code).HasColumnName(@"code").HasColumnType("nvarchar(8)").IsRequired().HasMaxLength(8).ValueGeneratedNever();
        }
    }

}
// </auto-generated>
