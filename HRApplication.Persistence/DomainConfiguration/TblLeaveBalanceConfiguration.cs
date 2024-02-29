using HRApplication.Domain.LeaveApplication;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRApplication.Persistence.DomainConfiguration;

public class TblLeaveBalanceConfiguration : IEntityTypeConfiguration<TblLeaveBalance>
{
    public void Configure(EntityTypeBuilder<TblLeaveBalance> builder)
    {
        builder.HasOne(e => e.TblEmployeeBasicInfo)
            .WithMany(d => d.TblLeaveBalance)
            .HasForeignKey(e => e.IntEmployeeId);

        builder.HasOne(e => e.TblLeaveTypeInfo)
            .WithMany(d => d.TblLeaveBalance)
            .HasForeignKey(e => e.IntLeaveTypeId);
    }
}

