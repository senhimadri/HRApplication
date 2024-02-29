using HRApplication.Domain.CommonDomain;


namespace HRApplication.Domain.EmployeeManagement;

public class TblGenderInfo :BaseDomainEntity
{
    public string StrGenderName { get; set; } = string.Empty;
    public string StrGenderCode { get; set; } = string.Empty;
}

