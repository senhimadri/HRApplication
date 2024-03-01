using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using HRApplication.Domain.MasterConfiguratio;

namespace HRApplication.Persistence.DomainConfiguration.MasterConfiguratioDomain;
public class TblAccountInfoConfiguration : IEntityTypeConfiguration<TblAccountInfo>
{
    public void Configure(EntityTypeBuilder<TblAccountInfo> builder)
    {

        builder.ToTable("TblAccountInfo", "base");

        builder.Property(e => e.StrAccountName)
            .HasMaxLength(100);
    }
}
