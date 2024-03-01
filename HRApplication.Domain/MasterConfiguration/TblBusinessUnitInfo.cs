using HRApplication.Domain.CommonDomain;
using System.Collections.ObjectModel;

namespace HRApplication.Domain.MasterConfiguratio;

public class TblBusinessUnitInfo : BaseDomainEntity
{
    public string StrBusinessUnitName { get; set; } = string.Empty;
    public string StrBusinessUnitDescreption { get; set; } = string.Empty;

    public long IntAccountId { get; set; }
    public TblAccountInfo TblAccountInfo { get; set; } = new TblAccountInfo();

    public ICollection<TblWorkplaceGroupInfo> TblWorkplaceGroupInfo { get; set; } = new Collection<TblWorkplaceGroupInfo>();
    //public ICollection<TblWorkplaceInfo> TblWorkplaceInfo { get; set; } = new Collection<TblWorkplaceInfo>();
}

