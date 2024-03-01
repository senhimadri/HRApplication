using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using HRApplication.Domain.MasterConfiguratio;

namespace HRApplication.Persistence.DomainConfiguration.MasterConfiguratioDomain;

public class TblWorkplaceInfoConfiguration : IEntityTypeConfiguration<TblWorkplaceInfo>
{
    public void Configure(EntityTypeBuilder<TblWorkplaceInfo> builder)
    {

        builder.ToTable("TblWorkplaceInfo", "base");

        builder.Property(e => e.StrWorkplaceName)
            .HasMaxLength(100);

        //builder.HasOne(e => e.TblAccountInfo)
        //        .WithMany(d => d.TblWorkplaceInfo)
        //        .HasForeignKey(e => e.IntPrimaryId);

        //builder.HasOne(e => e.TblBusinessUnitInfo)
        //        .WithMany(d => d.TblWorkplaceInfo)
        //        .HasForeignKey(e => e.IntPrimaryId);

        builder.HasOne(e => e.TblWorkplaceGroupInfo)
                .WithMany(d => d.TblWorkplaceInfo)
                .HasForeignKey(e => e.IntPrimaryId);
    }
}
