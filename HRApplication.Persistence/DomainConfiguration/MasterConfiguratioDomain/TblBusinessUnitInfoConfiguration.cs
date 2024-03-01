using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using HRApplication.Domain.MasterConfiguratio;

namespace HRApplication.Persistence.DomainConfiguration.MasterConfiguratioDomain;

public class TblBusinessUnitInfoConfiguration : IEntityTypeConfiguration<TblBusinessUnitInfo>
{
    public void Configure(EntityTypeBuilder<TblBusinessUnitInfo> builder)
    {

        builder.ToTable("TblBusinessUnitInfo", "base");

        builder.Property(e => e.StrBusinessUnitName)
            .HasMaxLength(100);

        builder.HasOne(e => e.TblAccountInfo)
                .WithMany(d => d.TblBusinessUnitInfo)
                .HasForeignKey(e => e.IntPrimaryId);
    }
}
