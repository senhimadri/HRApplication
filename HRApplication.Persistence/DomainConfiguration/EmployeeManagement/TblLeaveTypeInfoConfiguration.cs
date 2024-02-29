using HRApplication.Domain.LeaveApplication;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRApplication.Persistence.DomainConfiguration.EmployeeManagement;

public class TblLeaveTypeInfoConfiguration : IEntityTypeConfiguration<TblLeaveTypeInfo>
{
    public void Configure(EntityTypeBuilder<TblLeaveTypeInfo> builder)
    {
        builder.HasData(
            new TblLeaveTypeInfo
            {
                IntPrimaryId = 1,
                StrLeaveTypeName = "Casual Leave",
                StrLeaveTypeCode = "CA001"
            },
            new TblLeaveTypeInfo
            {
                IntPrimaryId = 2,
                StrLeaveTypeName = "Sick Leave",
                StrLeaveTypeCode = "SCK002"

            });
    }
}

