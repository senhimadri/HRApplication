using HRApplication.Domain.LeaveManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRApplication.Persistence.DomainConfiguration.LeaveApplication;

public class TblLeaveBalanceConfiguration : IEntityTypeConfiguration<TblLeaveBalance>
{
    public void Configure(EntityTypeBuilder<TblLeaveBalance> builder)
    {
        builder.ToTable("TblLeaveBalance", "lev");

        builder.HasOne(e => e.TblEmployeeBasicInfo)
            .WithMany(d => d.TblLeaveBalance)
            .HasForeignKey(e => e.IntEmployeeId);

        builder.HasOne(e => e.TblLeaveTypeInfo)
            .WithMany(d => d.TblLeaveBalance)
            .HasForeignKey(e => e.IntLeaveTypeId);
    }
}

