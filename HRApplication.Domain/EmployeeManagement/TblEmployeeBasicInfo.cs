using HRApplication.Domain.CommonDomain;
using HRApplication.Domain.LeaveManagement;

namespace HRApplication.Domain.EmployeeManagement;

public class TblEmployeeBasicInfo : BaseDomainEntity
{
    public string? StrEmployeeName { get; set; }
    public string? StrEmployeeCode { get; set; }
    public DateTime? DteDateOfBirth { get; set; } = new DateTime();

    public long IntDepartmentId { get; set; }
    public TblDepartmentInfo? TblDepartmentInfo { get; set; }
    public long IntDesignationId { get; set; }
    public TblDesignationInfo? TblDesignationInfo { get; set; } 
    public long IntGenderId { get; set; }
    public TblGenderInfo? TblGenderInfo { get; set; }
    public long IntReligionId { get; set; }
    public TblReligionInfo? TblReligionInfo { get; set; }
    public ICollection<TblLeaveBalance>? TblLeaveBalance { get; set; }
    public ICollection<TblLeaveApplication>? TblLeaveApplication { get; set; } 
}

