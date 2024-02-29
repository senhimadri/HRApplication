using HRApplication.Domain.CommonDomain;
using HRApplication.Domain.LeaveApplication;
using System.Collections.ObjectModel;

namespace HRApplication.Domain.EmployeeManagement;

public class TblEmployeeBasicInfo : BaseDomainEntity
{
    public string StrEmployeeName { get; set; } = string.Empty;
    public string StrEmployeeCode { get; set; } = string.Empty;
    public DateTime DteDateOfBirth { get; set; } = new DateTime();

    public long IntDepartmentId { get; set; }
    public TblDepartmentInfo TblDepartmentInfo { get; set; } = new TblDepartmentInfo();

    public long IntDesignationId { get; set; }
    public TblDesignationInfo TblDesignationInfo { get; set; } = new TblDesignationInfo();
    public long IntGenderId { get; set; }
    public TblGenderInfo TblGenderInfo { get; set; } = new TblGenderInfo();
    public long IntReligionId { get; set; }
    public TblReligionInfo TblReligionInfo { get; set; } = new TblReligionInfo();


    public ICollection<TblLeaveBalance> TblLeaveBalance { get; set; } = new Collection<TblLeaveBalance>();
    public ICollection<TblLeaveApplication> TblLeaveApplication { get; set; } = new Collection<TblLeaveApplication>();
}

