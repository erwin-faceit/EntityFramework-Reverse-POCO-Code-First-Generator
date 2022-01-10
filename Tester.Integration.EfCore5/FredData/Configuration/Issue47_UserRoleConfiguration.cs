// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace V5Fred
{
    // UserRoles
    public class Issue47_UserRoleConfiguration : IEntityTypeConfiguration<Issue47_UserRole>
    {
        public void Configure(EntityTypeBuilder<Issue47_UserRole> builder)
        {
            builder.ToTable("UserRoles", "Issue47");
            builder.HasKey(x => x.UserRoleId).HasName("PK__UserRole__3D978A3562D2BF0E").IsClustered();

            builder.Property(x => x.UserRoleId).HasColumnName(@"UserRoleId").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.UserId).HasColumnName(@"UserId").HasColumnType("int").IsRequired();
            builder.Property(x => x.RoleId).HasColumnName(@"RoleId").HasColumnType("int").IsRequired();

            // Foreign keys
            builder.HasOne(a => a.Issue47_Role).WithMany(b => b.Issue47_UserRoles).HasForeignKey(c => c.RoleId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("Issue47_UserRoles_roleid");
            builder.HasOne(a => a.Issue47_User).WithMany(b => b.Issue47_UserRoles).HasForeignKey(c => c.UserId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("Issue47_UserRoles_userid");
        }
    }

}
// </auto-generated>
