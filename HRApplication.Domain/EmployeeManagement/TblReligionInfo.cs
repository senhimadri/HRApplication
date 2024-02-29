using HRApplication.Domain.CommonDomain;

namespace HRApplication.Domain.EmployeeManagement;

public class TblReligionInfo: BaseDomainEntity
{
    public string StrReligionName { get; set; } = string.Empty;
    public string StrReligionCode { get; set; } = string.Empty;
}

