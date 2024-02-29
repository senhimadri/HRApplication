using HRApplication.Domain.LeaveApplication;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRApplication.Persistence.DomainConfiguration;

public class TblLeaveApplicationConfiguration : IEntityTypeConfiguration<TblLeaveApplication>
{
    public void Configure(EntityTypeBuilder<TblLeaveApplication> builder)
    {
        builder.HasOne(e => e.TblEmployeeBasicInfo)
            .WithMany(d => d.TblLeaveApplication)
            .HasForeignKey(e => e.IntEmployeeId);

        builder.HasOne(e => e.TblLeaveTypeInfo)
            .WithMany(d => d.TblLeaveApplication)
            .HasForeignKey(e => e.IntLeaveTypeId);
    }
}

