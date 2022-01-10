// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tester.Integration.EfCore2
{
    // workflow
    public class Alpha_WorkflowConfiguration : IEntityTypeConfiguration<Alpha_Workflow>
    {
        public void Configure(EntityTypeBuilder<Alpha_Workflow> builder)
        {
            builder.ToTable("workflow", "Alpha");
            builder.HasKey(x => x.Id).HasName("PK__workflow__3214EC0781E073BC").ForSqlServerIsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseSqlServerIdentityColumn();
            builder.Property(x => x.Description).HasColumnName(@"Description").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
        }
    }

}
// </auto-generated>
