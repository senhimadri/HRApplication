using HRApplication.Domain.CommonDomain;
using System.Collections.ObjectModel;

namespace HRApplication.Domain.LeaveManagement;

public class TblLeaveTypeInfo : BaseDomainEntity
{
    public string StrLeaveTypeName { get; set; } = string.Empty;
    public string StrLeaveTypeCode { get; set; } = string.Empty;

    public ICollection<TblLeaveBalance> TblLeaveBalance { get; set; } = new Collection<TblLeaveBalance>();
    public ICollection<TblLeaveApplication> TblLeaveApplication { get; set; } = new Collection<TblLeaveApplication>();
}

