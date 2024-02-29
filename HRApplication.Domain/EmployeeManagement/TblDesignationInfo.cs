using HRApplication.Domain.CommonDomain;
using System.Collections.ObjectModel;

namespace HRApplication.Domain.EmployeeManagement;

public class TblDesignationInfo : BaseDomainEntity
{
    public string StrDesignationName { get; set; } = string.Empty;
    public string StrDesignationCode { get; set; } = string.Empty;
    public ICollection<TblEmployeeBasicInfo> TblEmployeeBasicInfo { get; set; } = new Collection<TblEmployeeBasicInfo>();
}

