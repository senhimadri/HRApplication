using HRApplication.Domain.CommonDomain;
using System.Collections.ObjectModel;

namespace HRApplication.Domain.LeaveManagement;

public class TblLeaveTypeInfo : BaseDomainEntity
{
    public string? StrLeaveTypeName { get; set; }
    public string? StrLeaveTypeCode { get; set; }

    public ICollection<TblLeaveBalance>? TblLeaveBalance { get; set; } 
    public ICollection<TblLeaveApplication>? TblLeaveApplication { get; set; }
}

