using HRApplication.Domain.CommonDomain;
using System.Collections.ObjectModel;

namespace HRApplication.Domain.MasterConfiguratio;

public class TblBusinessUnitInfo : BaseDomainEntity
{
    public string? StrBusinessUnitName { get; set; }
    public string? StrBusinessUnitDescreption { get; set; }

    public long IntAccountId { get; set; }
    public TblAccountInfo? TblAccountInfo { get; set; }

    public ICollection<TblWorkplaceGroupInfo>? TblWorkplaceGroupInfo { get; set; }
}

