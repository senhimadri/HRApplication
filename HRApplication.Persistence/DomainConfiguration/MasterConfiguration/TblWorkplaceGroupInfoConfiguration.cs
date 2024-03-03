using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using HRApplication.Domain.MasterConfiguratio;

namespace HRApplication.Persistence.DomainConfiguration.MasterConfiguration;

public class TblWorkplaceGroupInfoConfiguration : IEntityTypeConfiguration<TblWorkplaceGroupInfo>
{
    public void Configure(EntityTypeBuilder<TblWorkplaceGroupInfo> builder)
    {

        builder.ToTable("TblWorkplaceGroupInfo", "base");

        builder.Property(e => e.StrWorkplaceGroupName)
            .HasMaxLength(100);

        builder.HasOne(e => e.TblBusinessUnitInfo)
                .WithMany(d => d.TblWorkplaceGroupInfo)
                .HasForeignKey(e => e.IntPrimaryId);
    }
}
