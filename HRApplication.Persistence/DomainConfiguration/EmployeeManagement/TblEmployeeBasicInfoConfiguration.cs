using HRApplication.Domain.EmployeeManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRApplication.Persistence.DomainConfiguration.EmployeeManagement;

public class TblEmployeeBasicInfoConfiguration : IEntityTypeConfiguration<TblEmployeeBasicInfo>
{
    public void Configure(EntityTypeBuilder<TblEmployeeBasicInfo> builder)
    {
        builder.HasOne(e => e.TblDepartmentInfo)
            .WithMany(d => d.TblEmployeeBasicInfo)
            .HasForeignKey(e => e.IntDepartmentId);

        builder.HasOne(e => e.TblDesignationInfo)
            .WithMany(d => d.TblEmployeeBasicInfo)
            .HasForeignKey(e => e.IntDesignationId);

        builder.HasOne(e => e.TblGenderInfo)
            .WithMany(d => d.TblEmployeeBasicInfo)
            .HasForeignKey(e => e.IntGenderId);

        builder.HasOne(e => e.TblReligionInfo)
            .WithMany(d => d.TblEmployeeBasicInfo)
            .HasForeignKey(e => e.IntReligionId);
    }
}

