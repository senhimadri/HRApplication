using HRApplication.Domain.CommonDomain;

namespace HRApplication.Domain.EmployeeManagement;

public class TblDepartmentInfo : BaseDomainEntity
{
    public string? StrDepartmentName { get; set; }
    public string? StrDepartmentCode { get; set; }

    public ICollection<TblEmployeeBasicInfo>? TblEmployeeBasicInfo { get; set; }
}

