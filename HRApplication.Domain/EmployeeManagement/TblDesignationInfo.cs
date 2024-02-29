using HRApplication.Domain.CommonDomain;

namespace HRApplication.Domain.EmployeeManagement;

public class TblDesignationInfo : BaseDomainEntity
{
    public string StrDesignationName { get; set; } = string.Empty;
    public string StrDesignationCode { get; set; } = string.Empty;
}

