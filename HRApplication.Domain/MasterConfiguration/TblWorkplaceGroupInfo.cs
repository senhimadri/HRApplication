using HRApplication.Domain.CommonDomain;
using System.Collections.ObjectModel;

namespace HRApplication.Domain.MasterConfiguratio;

public class TblWorkplaceGroupInfo : BaseDomainEntity
{
    public string? StrWorkplaceGroupName { get; set; }
    public string? StrWorkplaceGroupDescreption { get; set; } 

    public long IntBusinessUnitId { get; set; }
    public TblBusinessUnitInfo? TblBusinessUnitInfo { get; set; } 

    public ICollection<TblWorkplaceInfo>? TblWorkplaceInfo { get; set; }
}

