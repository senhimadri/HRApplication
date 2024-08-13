using HRApplication.Domain.CommonDomain;
using System.Collections.ObjectModel;

namespace HRApplication.Domain.EmployeeManagement;

public class TblDesignationInfo : BaseDomainEntity
{
    public string? StrDesignationName { get; set; }
    public string? StrDesignationCode { get; set; }
    public ICollection<TblEmployeeBasicInfo>? TblEmployeeBasicInfo { get; set; }
}

