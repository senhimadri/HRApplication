using HRApplication.Domain.CommonDomain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace HRApplication.Persistence.DomainConfiguration.MasterConfiguration;
public class TblAccountInfoConfiguration : IEntityTypeConfiguration<AccountInformation>
{
    public void Configure(EntityTypeBuilder<AccountInformation> builder)
    {
        builder.ToTable("AccountInformation", "base");

        // Configure the primary key
        builder.HasKey(e => e.IntAccountId);

        // Configure the primary key property as an identity column
        builder.Property(e => e.IntAccountId)
            .ValueGeneratedOnAdd();

        // Configure other properties
        builder.Property(e => e.StrAccountName)
            .HasMaxLength(100);
    }
}
