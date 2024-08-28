using HRApplication.Domain.CommonDomain;
using HRApplication.Domain.EmployeeManagement;

namespace HRApplication.Domain.LeaveManagement;

public class TblLeaveBalance : BaseDomainEntity
{
    public long IntEmployeeId { get; set; }
    public TblEmployeeBasicInfo? TblEmployeeBasicInfo { get; set; }
    public long IntLeaveTypeId { get; set; }
    public TblLeaveTypeInfo? TblLeaveTypeInfo { get; set; }
    public int IntYearId { get; set; }
    public int IntLeaveBalance { get; set; }
    public int IntLeaveTaken { get; set; }
    public int IntLeaveRemaining { get; set; }

}

