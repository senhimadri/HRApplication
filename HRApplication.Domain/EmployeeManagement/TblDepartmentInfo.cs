using HRApplication.Domain.CommonDomain;

namespace HRApplication.Domain.EmployeeManagement;

public class TblDepartmentInfo: BaseDomainEntity
{
    public string StrDepartmentName { get; set; } = string.Empty;
    public string StrDepartmentCode { get; set; } = string.Empty;
}

