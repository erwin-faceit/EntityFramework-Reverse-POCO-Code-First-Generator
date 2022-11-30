// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace V7EfrpgTest
{
    // FinancialInstitutionOffice
    public class FinancialInstitutionOfficeConfiguration : IEntityTypeConfiguration<FinancialInstitutionOffice>
    {
        public void Configure(EntityTypeBuilder<FinancialInstitutionOffice> builder)
        {
            builder.ToTable("FinancialInstitutionOffice", "dbo");
            builder.HasKey(x => x.FinancialInstitutionCode);

            builder.Property(x => x.Code).HasColumnName(@"Code").HasColumnType("uniqueidentifier").IsRequired();
            builder.Property(x => x.FinancialInstitutionCode).HasColumnName(@"FinancialInstitutionCode").HasColumnType("uniqueidentifier").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.OfficeName).HasColumnName(@"OfficeName").HasColumnType("nvarchar(200)").IsRequired(false).HasMaxLength(200);

            builder.HasIndex(x => new { x.FinancialInstitutionCode, x.OfficeName }).HasDatabaseName("UniqueOfficeName_FinancialInstitutionOffice").IsUnique();
        }
    }

}
// </auto-generated>
